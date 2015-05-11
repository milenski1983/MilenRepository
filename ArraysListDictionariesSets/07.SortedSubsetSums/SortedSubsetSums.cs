using System;
using System.Collections.Generic;
using System.Linq;

namespace SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] inputStringArray = input.Split();
            int[] inputIntArray = new int[inputStringArray.Length];
            bool sequenceSumExist = false;

            for (int i = 0; i < inputStringArray.Length; i++)
            {
                inputIntArray[i] = int.Parse(inputStringArray[i]);
            }

            HashSet<string> uniqueCombinations = new HashSet<string>();
            List<int> currentCombination = new List<int>();
            int combinations = (int)Math.Pow(2, inputIntArray.Length);
            for (int i = 1; i < combinations; i++)
            {
                currentCombination.Clear();
                string binaryCombinations = Convert.ToString(i, 2).PadLeft((int)Math.Log(combinations, 2), '0');
                for (int j = 0; j < binaryCombinations.Length; j++)
                {
                    if (binaryCombinations[j] == '1')
                    {
                        currentCombination.Add(inputIntArray[j]);
                    }
                }

                if (currentCombination.Sum() == sum)
                {
                    sequenceSumExist = true;
                    currentCombination.Sort();
                    string output = string.Join(" + ", currentCombination);
                    uniqueCombinations.Add(output);
                }
            }

            List<string> sortedUniqueCombinations = new List<string>(uniqueCombinations);
            sortedUniqueCombinations.Sort((a, b) => a.Length.CompareTo(b.Length));
            
            if (sequenceSumExist)
            {
                foreach (string output in sortedUniqueCombinations)
                {
                    Console.WriteLine(output + " = " + sum);
                }
            }
            else
            {
                Console.WriteLine("No matching subsets.");
            }
        }

    }
}
