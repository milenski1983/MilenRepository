using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Night_Life
{
    class Record: IComparable<Record>
    {
        private string city;
        private string club;
        private string performer;

        public string City
        {
            get { return this.city; }
        }

        public string Club
        {
            get { return this.club; }
        }

        public string Performer
        {
            get { return this.performer; }
        }

        public Record(string city, string club, string performer)
        {
            this.city = city;
            this.club = club;
            this.performer = performer;
        }

        public int CompareTo(Record record)
        {
            return this.Club.CompareTo(record.Club);
        }
    }

    class NightLife
    {
        static void Main(string[] args)
        {
            HashSet<string> cities = new HashSet<string>();
            SortedSet<string> clubs = new SortedSet<string>();
            List<Record> records = new List<Record>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "END")
                {
                    string[] inputArray = input.Split(';');
                    string city = inputArray[0];
                    cities.Add(city);
                    string club = inputArray[1];
                    clubs.Add(club);
                    string performer = inputArray[2];
                    records.Add(new Record(city, club, performer));
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < records.Count - 1; i++)
            { 
                for (int j = i + 1; j < records.Count; j++)
                {
                    if ((records[j].City == records[i].City) && (records[j].Club == records[i].Club) && (records[j].Performer == records[i].Performer))
                    {
                        records.RemoveAt(j);
                    }
                }
            }

            foreach (string city in cities)
            {
                Console.WriteLine(city);
                string outputClub;
                string outputPerformers;
                foreach (string club in clubs)
                {
                    outputClub = "";
                    outputPerformers = "";
                    foreach (Record record in records)
                    {
                        if (record.City == city && record.Club == club)
                        {
                            outputClub = club;
                            outputPerformers += record.Performer + ", ";
                        }
                    }
                    if (outputPerformers.Length != 0 )
                    {
                        Console.WriteLine("->{0}: {1}",outputClub, outputPerformers.Trim(',', ' '));
                    }
                }
            }
        }
    }
}
