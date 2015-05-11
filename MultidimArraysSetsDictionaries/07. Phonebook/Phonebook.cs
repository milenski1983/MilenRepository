using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();;
            do
            {
                string[] inputArray = input.Split('-');
                string name = inputArray[0];
                List<string> number = new List<string>();
                
                //multiple phone numbers per contact
                if (phonebook.ContainsKey(name))
                {
                    number = phonebook[name];
                    number.Add(inputArray[1]);
                    phonebook[name] = number;
                }
                else
                {
                    number.Add(inputArray[1]);
                    phonebook.Add(name, number);
                }
                input = Console.ReadLine();

            } while (input != "search");

            while (true)
            {
                string searchParam = Console.ReadLine();
                if (searchParam != "")
                {
                    if (phonebook.ContainsKey(searchParam))
                    {
                        foreach (string item in phonebook[searchParam])
                        {
                            Console.WriteLine("{0} -> {1}", searchParam, item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", searchParam);
                    }
                }
                else
                {
                    Console.WriteLine("No name to search.");
                    break;
                }
            }
        }
    }
}
