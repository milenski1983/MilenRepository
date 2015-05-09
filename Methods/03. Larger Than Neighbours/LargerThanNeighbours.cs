using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Larger_Than_Neighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("numbers[{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        private static bool IsLargerThanNeighbours(int[] numbers, int i)
        {
            if (i == 0)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (i == numbers.Length - 1)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
