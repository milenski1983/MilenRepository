using System;
using System.Collections.Generic;
using System.Linq;

namespace PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int combinations = (int)Math.Pow(2, n);
            bool[] pythagoreanCombination = { false };

            for (int i = 0; i < combinations; i++)
            {
                bool threeOnesCombination = CheckForThreeOnes(i, n);
                if (threeOnesCombination)
                {
                    ExaminCombinations(i, numbers, pythagoreanCombination);
                }
            }
            if (pythagoreanCombination[0] == false)
            {
                Console.WriteLine("No");
            }
        }

        private static void ExaminCombinations(int index, int[] numbers, bool[] pythagoreanCombination)
        {
            string iToString = Convert.ToString(index, 2).PadLeft(numbers.Length, '0');
            int[] abc = new int[3];
            int abcIndex = 0;
            for (int i = 0; i < iToString.Length; i++)
            {
                if (iToString[i] == '1')
                {
                    abc[abcIndex] = numbers[i];
                    abcIndex++;
                }
            }
            CkeckForPythagoreanNumbers(abc[0], abc[1], abc[2], pythagoreanCombination);
            CkeckForPythagoreanNumbers(abc[0], abc[2], abc[1], pythagoreanCombination);
            CkeckForPythagoreanNumbers(abc[1], abc[0], abc[2], pythagoreanCombination);
            CkeckForPythagoreanNumbers(abc[1], abc[2], abc[0], pythagoreanCombination);
            CkeckForPythagoreanNumbers(abc[2], abc[1], abc[0], pythagoreanCombination);
            CkeckForPythagoreanNumbers(abc[2], abc[0], abc[1], pythagoreanCombination);
        }

        private static void CkeckForPythagoreanNumbers(int a, int b, int c, bool[] pythagoreanCombination)
        {
            int aSquare = (int)Math.Pow(a, 2);
            int bSquare = (int)Math.Pow(b, 2);
            int cSquare = (int)Math.Pow(c, 2);

            if (a <= b)
            {
                if (aSquare + bSquare == cSquare)
                {
                    pythagoreanCombination[0] = true;
                    Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                }
            }
        }

        private static bool CheckForThreeOnes(int i, int n)
        {
            bool threeOnes = false;
            string iToString = Convert.ToString(i, 2).PadLeft(n, '0');
            int counter = 0;
            foreach (char item in iToString)
            {
                if (item == '1')
                {
                    counter++;
                }
            }
            if (counter == 3)
            {
                threeOnes = true;
            }
            return threeOnes;
        }
    }
}
