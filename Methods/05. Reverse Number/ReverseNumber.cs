using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;


namespace _05.Reverse_Number
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double number = double.Parse(Console.ReadLine());
            double reversed = Reverse(number);
            Console.WriteLine(reversed);
        }

        private static double Reverse(double number)
        {
            string numberString = number.ToString();
            char[] reversedNumberString = new char[numberString.Length];

            for (int i = 0; i < numberString.Length; i++)
            {
                reversedNumberString[i] = numberString[numberString.Length - (1 + i)];
            }

            return double.Parse(new string(reversedNumberString));
        }
    }
}
