using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckNumbers
{
    class StuckNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] inputArray = input.Split();
            bool stickNumbersExist = false;
            HashSet<string> numbers = new HashSet<string>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                string a = inputArray[i];
                for (int j = 0; j < inputArray.Length; j++)
                {
                    string b = inputArray[j];
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        string c = inputArray[k];
                        for (int l = 0; l < inputArray.Length; l++)
                        {
                            string d = inputArray[l];
                            numbers.Clear();
                            numbers.Add(a);
                            numbers.Add(b);
                            numbers.Add(c);
                            numbers.Add(d);
                            if (numbers.Count == 4)
                            {
                                if ((a + b) == (c + d))
                                {
                                    stickNumbersExist = true;
                                    Console.WriteLine("{0}|{1} == {2}|{3}", a, b, c, d);
                                }
                            }
                        }
                    }
                }
            }

            if (!stickNumbersExist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
