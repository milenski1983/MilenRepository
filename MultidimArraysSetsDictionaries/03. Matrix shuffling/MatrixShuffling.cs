using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Matrix_shuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            string command;
            do
            {
                command = Console.ReadLine();
                string[] commandArray = command.Split();
                if ((commandArray[0] == "swap") && (commandArray.Length == 5))
                {
                    string swap = commandArray[0];
                    int firstValueX = int.Parse(commandArray[1]);
                    int firstValueY = int.Parse(commandArray[2]);
                    int secondValueX = int.Parse(commandArray[3]);
                    int secondValueY = int.Parse(commandArray[4]);

                    if ((firstValueX < matrix.GetLength(0)) && (firstValueY < matrix.GetLength(1)) && 
                        (secondValueX < matrix.GetLength(0)) && (secondValueY < matrix.GetLength(1)))
                    {
                        matrix = SwapValues(firstValueX, firstValueY, secondValueX, secondValueY, matrix);
                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                {
                    if (commandArray[0] != "END")
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            } while (command != "END");
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ",matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static string[,] SwapValues(int firstValueX, int firstValueY, int secondValueX, int secondValueY, string[,] matrix)
        {
            string temp = matrix[firstValueX, firstValueY];
            matrix[firstValueX, firstValueY] = matrix[secondValueX, secondValueY];
            matrix[secondValueX, secondValueY] = temp;
            return matrix;
        }
    }
}
