using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Last_Digit_of_Number
{
    class LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string lastDigit = GetLastDigitAsWord(number);
            Console.WriteLine(lastDigit);
        }

        private static string GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
                default:
                    return "";
                    break;
            }
        }
    }
}
