using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Letters_change_Numbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string input = Console.ReadLine();
            string[] inputArray = input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            foreach (string entry in inputArray)
            {
                char firstLetter = entry[0];
                char lastLetter = entry[entry.Length - 1];
                string numberString = "";
                for (int i = 1; i < entry.Length - 1; i++)
                {
                    numberString += entry[i];
                }

                int number = int.Parse(numberString);
                double result;

                if ((int)firstLetter >= 65 && (int)firstLetter <= 90)
                {
                    result = (double)number / ((int)firstLetter - 64);
                }
                else
                {
                    result = (double)number * ((int)firstLetter - 96);
                }

                if ((int)lastLetter >= 65 && (int)lastLetter <= 90)
                {
                    result -= ((int)lastLetter - 64);
                }
                else
                {
                    result += ((int)lastLetter - 96);
                }

                sum += result;
            }

            Console.WriteLine("{0:f2}",sum);
        }
    }
}
