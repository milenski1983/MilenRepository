using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace _06.Number_Calculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double[] arrayOfDoubles = { 2.453, 1.457, 7.91, -8.14, 0, 2, 4587, -6.004 };
            decimal[] arrayOfDecimals = { 3.487m, 1.852m, 5.94m, -0.5m, 2.00m, 45879, -6.000004m };

            double arrayOfDoublesMin = GetMin(arrayOfDoubles);
            double arrayOfDoublesMax = GetMax(arrayOfDoubles);
            double arrayOfDoublesSum = GetSum(arrayOfDoubles);
            double arrayOfDoublesAverage = GetAverage(arrayOfDoubles.Length, arrayOfDoublesSum);

            decimal arrayOfDecimalsMin = GetMin(arrayOfDecimals);
            decimal arrayOfDecimalsMax = GetMax(arrayOfDecimals);
            decimal arrayOfDecimalsSum = GetSum(arrayOfDecimals);
            decimal arrayOfDecimalsAverage = GetAverage(arrayOfDecimals.Length, arrayOfDecimalsSum);

            Console.WriteLine("For the array of doubles: Min: {0}, Max: {1}, Sum: {2}, Average: {3}",
                arrayOfDoublesMin, arrayOfDoublesMax, arrayOfDoublesSum, arrayOfDoublesAverage);
            Console.WriteLine("For the array of decimals: Min: {0}, Max: {1}, Sum: {2}, Average: {3}",
                arrayOfDecimalsMin, arrayOfDecimalsMax, arrayOfDecimalsSum, arrayOfDecimalsAverage);

        }

        private static double GetAverage(int arrayLength, double arraySum)
        {
            return arraySum / arrayLength;
        }

        private static decimal GetAverage(int arrayLength, decimal arraySum)
        {
            return arraySum / arrayLength;
        }

        private static double GetSum(double[] arrayOfNumbers)
        {
            double sum = 0;
            foreach (double item in arrayOfNumbers)
            {
                sum += item;
            }
            return sum;
        }

        private static decimal GetSum(decimal[] arrayOfNumbers)
        {
            decimal sum = 0;
            foreach (decimal item in arrayOfNumbers)
            {
                sum += item;
            }
            return sum;
        }

        private static double GetMax(double[] arrayOfNumbers)
        {
            double max = double.MinValue;
            foreach (double item in arrayOfNumbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        private static decimal GetMax(decimal[] arrayOfNumbers)
        {
            decimal max = decimal.MinValue;
            foreach (decimal item in arrayOfNumbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        private static double GetMin(double[] arrayOfNumbers)
        {
            double min = double.MaxValue;
            foreach (double item in arrayOfNumbers)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        private static decimal GetMin(decimal[] arrayOfNumbers)
        {
            decimal min = decimal.MaxValue;
            foreach (decimal item in arrayOfNumbers)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        
    }
}
