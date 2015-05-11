using System;
using System.Collections.Generic;
using System.Linq;


namespace SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split();

            List<string> sequence = new List<string>();
            string currentString = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].ToLower() == currentString.ToLower())
                {
                    sequence.Add(inputArray[i]);
                }
                else
                {
                    Console.WriteLine(string.Join(" ",sequence));
                    sequence.Clear();
                    currentString = inputArray[i];
                    sequence.Add(currentString);
                }
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
