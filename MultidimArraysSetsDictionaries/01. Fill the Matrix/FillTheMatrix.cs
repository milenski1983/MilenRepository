using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Fill_the_Matrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter matrix dimentions N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrixA = new int[n, n];
            int[,] matrixB = new int[n, n];
            Console.WriteLine();

            matrixA = FillUpMatrixA(matrixA);
            matrixB = FillUpMatrixB(matrixB);

            PrintMatrix(matrixA);
            PrintMatrix(matrixB);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,-3}", matrix[row,col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[,] FillUpMatrixB(int[,] matrixB)
        {
            int counter = 1;
            for (int col = 0; col < matrixB.GetLength(1); col++)
            {
                if ((col % 2 == 0) || (col == 0))
                {
                    for (int row = 0; row < matrixB.GetLength(0); row++)
                    {
                        matrixB[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = matrixB.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrixB[row, col] = counter;
                        counter++;
                    }
                }
            }
            return matrixB;
        }

        private static int[,] FillUpMatrixA(int[,] matrixA)
        {
            int counter = 1;
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                for (int row = 0; row < matrixA.GetLength(0); row++)
                {
                    matrixA[row, col] = counter;
                    counter++;
                }
            }
            return matrixA;
        }
    }
}
