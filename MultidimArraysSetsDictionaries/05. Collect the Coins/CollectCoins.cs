using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Collect_the_Coins
{
    class CollectCoins
    {
        static void Main(string[] args)
        {
            string[] array = new string[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }

            int row = 0; //array index
            int col = 0; //current string index;

            int coinsCounter = 0;
            int wallHitsCounter = 0;

            string directions = Console.ReadLine();
            foreach (char direction in directions)
            {
                string currentString;
                char currentChar;
                switch (direction)
                {
                    case 'V':
                        row++;
                        if (row >= array.Length || col >= array[row].Length)
                        {
                            wallHitsCounter++;
                            row--;
                            break;
                        }
                        currentString = array[row];
                        currentChar = currentString[col];
                        if (currentChar == '$')
                        {
                            coinsCounter++;
                        }
                        break;

                    case '^':
                        row--;
                        if (row < 0 || col >= array[row].Length)
                        {
                            wallHitsCounter++;
                            row++;
                            break;
                        }
                        currentString = array[row];
                        currentChar = currentString[col];
                        if (currentChar == '$')
                        {
                            coinsCounter++;
                        }
                        break;

                    case '>':
                        col++;
                        if (col >= array[row].Length)
                        {
                            wallHitsCounter++;
                            col--;
                            break;
                        }
                        currentString = array[row];
                        currentChar = currentString[col];
                        if (currentChar == '$')
                        {
                            coinsCounter++;
                        }
                        break;

                    case '<':
                        col--;
                        if (col < 0)
                        {
                            wallHitsCounter++;
                            col++;
                            break;
                        }
                        currentString = array[row];
                        currentChar = currentString[col];
                        if (currentChar == '$')
                        {
                            coinsCounter++;
                        }
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("Coins collected: {0}", coinsCounter);
            Console.WriteLine("Walls hit: {0}", wallHitsCounter);
        }
    }
}
