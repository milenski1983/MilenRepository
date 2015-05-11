using System;
using System.Collections.Generic;
using System.Linq;


namespace _09.Terrorists_Win
{
    class TerroristsWin
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split('|');

            for (int i = 0; i < inputArray.Length; i += 2)
            {
                if (i == 0)
                {
                    int numberOfDots = DetermineBombPower(inputArray[i + 1]);
                    char[] currentString = inputArray[i].ToCharArray();
                    inputArray[i] = DestroyLetters(currentString, numberOfDots, "nextCell");
                }
                else if (i == inputArray.Length - 1)
                {
                    int numberOfDots = DetermineBombPower(inputArray[i - 1]);
                    char[] currentString = inputArray[i].ToCharArray();
                    inputArray[i] = DestroyLetters(currentString, numberOfDots, "previousCell");
                }
                else
                {
                    int numberOfDotsPreviousCell = DetermineBombPower(inputArray[i - 1]);
                    int numberOfDotsNextCell = DetermineBombPower(inputArray[i + 1]);
                    char[] currentString = inputArray[i].ToCharArray();
                    inputArray[i] = DestroyLetters(currentString, numberOfDotsPreviousCell, numberOfDotsNextCell);
                }
            }

            for (int i = 1; i < inputArray.Length; i += 2)
            {
                inputArray[i] = ConvertToDots(inputArray[i].Length + 2);
            }

            Console.WriteLine(string.Join("",inputArray));
        }

        private static int DetermineBombPower(string bomb)
        {
            int bombPower = 0;
            foreach (char item in bomb)
            {
                bombPower += (int)item;
            }
            return bombPower % 10;
        }

        private static string DestroyLetters(char[] currentString, int numberOfDotsPreviousCell, int numberOfDotsNextCell)
        {
            for (int i = 0; i < numberOfDotsPreviousCell; i++)
            {
                currentString[i] = '.';
            }
            for (int i = currentString.Length - 1; i >= currentString.Length - numberOfDotsNextCell; i--)
            {
                currentString[i] = '.';
            }
            return new string(currentString);
        }

        private static string DestroyLetters(char[] currentString, int numberOfDots, string bombCell)
        {
            switch (bombCell)
            {
                case "previousCell":
                    for (int i = 0; i < numberOfDots; i++)
                    {
                        currentString[i] = '.';
                    }
                    break;
                case "nextCell":
                    for (int i = currentString.Length - 1; i >= currentString.Length - numberOfDots; i--)
                    {
                        currentString[i] = '.';
                    }
                    break;
                default:
                    break;
            }
            return new string(currentString);
        }

        private static string ConvertToDots(int length)
        {
            char[] charArray = new char[length];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = '.';
            }
            return new string(charArray);
        }
    }
}
