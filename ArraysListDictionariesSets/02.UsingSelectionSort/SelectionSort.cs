using System;
using System.Collections.Generic;
using System.Linq;


namespace UsingSelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputStringArray = input.Split();
            int[] inputIntArray = new int[inputStringArray.Length];

            for (int i = 0; i < inputStringArray.Length; i++)
            {
                inputIntArray[i] = int.Parse(inputStringArray[i]);
            }

            int counter = 0;
            while (counter < inputIntArray.Length)
            {
                int minValue = int.MaxValue;
                int minValueIndex = counter;
                for (int i = counter; i < inputIntArray.Length; i++)
                {
                    if (minValue < inputIntArray[i])
                    {
                        minValue = inputIntArray[i];
                        minValueIndex = i;
                    }
                }
                int temp = inputIntArray[counter];
                inputIntArray[counter] = minValue;
                inputIntArray[minValueIndex] = temp;
                counter++;
            }

            foreach (int number in inputIntArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
