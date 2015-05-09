using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.First_Larger_Than_Neighbours
{
    class FirstLargerThanNeighbours
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

            Console.WriteLine(GetFirstLargerThanNeighbours(numbers));
        }

        private static int GetFirstLargerThanNeighbours(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        return i;
                    }
                }
                else if (i == numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        return i;
                    }    
                }
                else
                {
                    if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
