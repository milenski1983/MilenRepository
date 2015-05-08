using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace CategorizeNumbers
{
    class CategorizeNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string input = Console.ReadLine();
            string[] inputStringArray = input.Split();
            double[] inputDoubleArray = new double[inputStringArray.Length];

            for (int i = 0; i < inputStringArray.Length; i++)
            {
                inputDoubleArray[i] = double.Parse(inputStringArray[i]);
            }

            List<double> floatingPointNumbers = new List<double>();
            List<double> Integers = new List<double>();

            foreach (double number in inputDoubleArray)
            {
                if (number % 1 == 0)
                {
                    Integers.Add(number);
                }
                else
                {
                    floatingPointNumbers.Add(number);
                }
            }

            PrintOutput(floatingPointNumbers);
            PrintOutput(Integers);
        }

        private static void PrintOutput(List<double> numbersList)
        {
            Console.Write("[" + String.Join(", ",numbersList) + "] -> ");
            Console.Write("min: " + numbersList.Min() + ", ");
            Console.Write("max: " + numbersList.Max() + ", ");
            Console.Write("sum: " + numbersList.Sum() + ", ");
            Console.Write("avg: {0:f2}", numbersList.Average());
            Console.WriteLine();
        }
    }
}
