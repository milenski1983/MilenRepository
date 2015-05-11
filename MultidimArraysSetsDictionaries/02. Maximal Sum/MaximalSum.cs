using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Maximal_Sum
{
    class Output
    {
        private int[,] maxSumSubMatrix;
        private int sum;

        public int[,] MaxSumSubMatrix
        {
            get { return this.maxSumSubMatrix; }
            set { this.maxSumSubMatrix = value;}
        }

        public int Sum
        {
            get { return this.sum; }
            set { this.sum = value; }
        }

        public Output()
        {
            this.sum = 0;
            this.maxSumSubMatrix = new int[3, 3];
        }
    }

    class MaximalSum
    {
        static void Main(string[] args)
        {
            string dimentions = Console.ReadLine();
            string[] dimentionsArray = dimentions.Split();
            int rows = int.Parse(dimentionsArray[0]);
            int columns = int.Parse(dimentionsArray[1]);            
            int[,] matrix = new int[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                string inputRow = Console.ReadLine();
                string[] inputRowArray = inputRow.Split();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = int.Parse(inputRowArray[col]);
                }
            }

            Output output = new Output();
            output = GetMaxSumSubMatrix(matrix, output);
            Console.WriteLine();
            Console.WriteLine("Sum = {0}", output.Sum);
            
            for (int row = 0; row < output.MaxSumSubMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < output.MaxSumSubMatrix.GetLength(0); col++)
                {
                    Console.Write("{0, -3}",output.MaxSumSubMatrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static Output GetMaxSumSubMatrix(int[,] matrix, Output output)
        {            
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int[,] currentSubMatrix = new int[3, 3];
                    int currentSubMatrixSum = 0;
                    for (int i = row; i < row + currentSubMatrix.GetLength(0); i++)
                    {
                        for (int j = col; j < col + currentSubMatrix.GetLength(0); j++)
                        {
                            currentSubMatrix[i - row, j - col] = matrix[i, j];
                            currentSubMatrixSum += matrix[i, j];
                        }
                    }
                    if (currentSubMatrixSum > output.Sum)
                    {
                        output.Sum = currentSubMatrixSum;
                        output.MaxSumSubMatrix = currentSubMatrix;
                    }
                }
            }
            return output;
        }
    }
}
