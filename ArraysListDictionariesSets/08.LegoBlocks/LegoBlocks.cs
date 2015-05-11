using System;
using System.Collections.Generic;
using System.Linq;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<Array> legos = new List<Array>();

            for (int i = 0; i < 2 * length; i++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split();
                legos.Add(inputArray);
            }

            int elementsLength = legos[0].Length + legos[length].Length;
            bool areFitting = true;
            for (int i = 0; i < length; i++)
            {
                if (legos[i].Length + legos[i + length].Length != elementsLength)
                {
                    areFitting = false;
                    break;
                }
            }

            if (areFitting)
            {
                for (int i = 0; i < length; i++)
                {
                    string output = "[";
                    foreach (string item in legos[i])
                    {
                        output += item + ", ";
                    }
                    foreach (string item in legos[i + length])
                    {
                        output += item + ", ";
                    }
                    Console.WriteLine((output.Trim(new char[] { ',', ' ' })) + "]");
                }
            }
            else
            {
                int numberOfCells = 0;
                foreach (var item in legos)
                {
                    numberOfCells += item.GetLength(0);
                }
                Console.WriteLine("The total number of cells is: {0}", numberOfCells);
            }
        }
    }
}
