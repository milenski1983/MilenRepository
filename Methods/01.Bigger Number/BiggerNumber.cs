using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bigger_Number
{
    class BiggerNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMaxNumber(firstNumber, secondNumber);
            Console.WriteLine(max);
        }

        private static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
