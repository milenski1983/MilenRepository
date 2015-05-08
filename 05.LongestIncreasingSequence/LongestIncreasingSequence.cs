using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split();
            int[] inputArrayInt = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArrayInt[i] = int.Parse(inputArray[i]);
            }

            List<int> currentSequence = new List<int>();
            List<int> maxLengthSequence = new List<int>();
            int previousInt = int.MinValue;
            for (int i = 0; i < inputArrayInt.Length; i++)
            {
                if (inputArrayInt[i] > previousInt)
                {
                    currentSequence.Add(inputArrayInt[i]);
                    previousInt = inputArrayInt[i];
                }
                else
                {
                    Console.WriteLine(string.Join(" ",currentSequence));
                    if (currentSequence.Count > maxLengthSequence.Count)
                    {
                        maxLengthSequence = new List<int>(currentSequence);
                    }
                    currentSequence.Clear();
                    currentSequence.Add(inputArrayInt[i]);
                    previousInt = inputArrayInt[i];
                }
            }

            Console.WriteLine(string.Join(" ", currentSequence));
            if (currentSequence.Count > maxLengthSequence.Count)
            {
                maxLengthSequence = new List<int>(currentSequence);
            }

            Console.WriteLine("Longest: " + string.Join(" ", maxLengthSequence));
        }
    }
}
