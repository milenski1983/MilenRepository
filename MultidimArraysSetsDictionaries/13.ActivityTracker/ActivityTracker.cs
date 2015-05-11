using System;
using System.Collections.Generic;
using System.Linq;


namespace ActivityTracker
{
    class ActivityTracker
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }

            foreach (string entry in input)
            {
                string[] inputSplit = entry.Split();
                DateTime date = DateTime.Parse(inputSplit[0]);
                string name = inputSplit[1];
                int distance = int.Parse(inputSplit[2]);
                bool isInList = false;

                foreach (Activity activity in activities)
                {
                    if (activity.Name == name && activity.Date.Month == date.Month)
                    {
                        isInList = true;
                        activity.Distance += distance;
                        break;
                    }
                }
                if (!isInList)
                {
                    activities.Add(new Activity(name, distance, date));
                }
            }
            activities.Sort();
            HashSet<int> months = new HashSet<int>();
            foreach (Activity activity in activities)
            {
                int month = activity.Date.Month;
                months.Add(month);
            }

            foreach (int month in months)
            {
                Console.Write("{0}: ",month);
                string output = "";
                foreach (Activity activity in activities)
                {
                    if (activity.Date.Month == month)
                    {
                        output += activity.Name + "(" + activity.Distance + "), ";
                    }
                }
                output = output.Trim(' ',',');
                Console.WriteLine(output);
            }
        }
    }
}
