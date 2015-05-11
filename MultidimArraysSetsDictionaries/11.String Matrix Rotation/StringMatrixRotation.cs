using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.String_Matrix_Rotation
{
    class StringMatrixRotation
    {
        static void Main(string[] args)
        {
            string rotationInput = Console.ReadLine();
            int angle = int.Parse(rotationInput.Substring(6).Trim('(',')'));

            List<string> inputs = new List<string>();
            List<int> inputsLength = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input != "END")
                {
                    inputs.Add(input);
                    inputsLength.Add(input.Length);
                }
                else
	            {
                    break;
	            }
            }

            int arrayRows = inputs.Count;
            int arrayCols = inputsLength.Max();
            char[,] charArray = new char[arrayRows, arrayCols];

            charArray = FillUpArray(charArray, inputs);
            
            switch (angle)
            {
                case 90:
                    charArray = Rotate90(charArray);
                    break;
                case 180:
                    charArray = Rotate180(charArray);
                    break;
                case 270:
                    charArray = Rotate270(charArray);
                    break;
                default:
                    break;
            }

            PrintArray(charArray);
        }

        private static char[,] FillUpArray(char[,] charArray, List<string> inputs)
        {
            for (int rows = 0; rows < charArray.GetLength(0); rows++)
            {
                string currentString = inputs[rows];
                for (int cols = 0; cols < currentString.Length; cols++)
                {
                    charArray[rows, cols] = currentString[cols];
                }
            }
            return charArray;
        }

        private static char[,] Rotate270(char[,] charArray)
        {
            char[,] rotatedCharArray = new char[charArray.GetLength(1), charArray.GetLength(0)];
            for (int row = 0; row < rotatedCharArray.GetLength(0); row++)
            {
                for (int col = 0; col < rotatedCharArray.GetLength(1); col++)
                {
                    rotatedCharArray[row, col] = charArray[col, charArray.GetLength(1) - 1 - row];
                }
            }
            return rotatedCharArray;
        }

        private static char[,] Rotate180(char[,] charArray)
        {
            char[,] rotatedCharArray = new char[charArray.GetLength(0), charArray.GetLength(1)];
            for (int row = 0; row < rotatedCharArray.GetLength(0); row++)
            {
                for (int col = 0; col < rotatedCharArray.GetLength(1); col++)
                {
                    rotatedCharArray[row, col] = charArray[charArray.GetLength(0) - 1 - row, charArray.GetLength(1) - 1 - col];
                }
            }
            return rotatedCharArray;
        }
        
        private static char[,] Rotate90(char[,] charArray)
        {
            char[,] rotatedCharArray = new char[charArray.GetLength(1), charArray.GetLength(0)];
            for (int row = 0; row < rotatedCharArray.GetLength(0); row++)
            {
                for (int col = 0; col < rotatedCharArray.GetLength(1); col++)
                {
                    rotatedCharArray[row, col] = charArray[charArray.GetLength(0) - 1 - col, row];
                }
            }
            return rotatedCharArray;
        }
        
        private static void PrintArray(char[,] charArray)
        {
            for (int i = 0; i < charArray.GetLength(0); i++)
            {
                for (int j = 0; j < charArray.GetLength(1); j++)
                {
                    Console.Write(charArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
