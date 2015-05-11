using System;
using System.Collections.Generic;
using System.Linq;


namespace _10.Plus_Remove
{
    class PlusRemove
    {
        static void Main(string[] args)
        {
            List<char[]> inputs = new List<char[]>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "END")
                {
                    inputs.Add(input.ToCharArray());
                }
                else
                {
                    break;
                }
            }

            List<char[]> inputsClone = new List<char[]>(inputs);
            HashSet<string> elementsToRemove = new HashSet<string>();

            for (int i = 1; i < inputsClone.Count - 1; i++)
            {
                for (int j = 1; j < inputsClone[i].Length; j++)
                {
                    char[] currentString = inputsClone[i];
                    char[] nextString = inputsClone[i + 1];
                    char[] previousString = inputsClone[i - 1];

                    if (j < currentString.Length && j < nextString.Length && j < previousString.Length)
                    {
                        if (currentString[j].ToString().ToLower() == nextString[j].ToString().ToLower() &&
                            currentString[j].ToString().ToLower() == currentString[j - 1].ToString().ToLower() &&
                            currentString[j].ToString().ToLower() == currentString[j + 1].ToString().ToLower() &&
                            currentString[j].ToString().ToLower() == previousString[j].ToString().ToLower())
                        {
                            elementsToRemove.Add((i - 1).ToString() + " " + j.ToString());
                            elementsToRemove.Add(i.ToString() + " " + (j - 1).ToString());
                            elementsToRemove.Add(i.ToString() + " " + j.ToString());
                            elementsToRemove.Add(i.ToString() + " " + (j + 1).ToString());
                            elementsToRemove.Add((i + 1).ToString() + " " + j.ToString());
                        }
                    }
                }
            }

            foreach (string element in elementsToRemove)
            {
                string[] elementArray = element.Split();
                int iIndex = int.Parse(elementArray[0]);
                int jIndex = int.Parse(elementArray[1]);

                for (int i = 0; i < inputsClone.Count; i++)
                {
                    char[] currentString = inputsClone[i];
                    for (int j = 0; j < currentString.Length; j++)
                    {
                        if (i == iIndex && j == jIndex)
                        {
                            currentString[j] = ' ';
                        }
                    }
                }
            }

            foreach (var item in inputsClone)
            {
                foreach (char symbol in item)
                {
                    if (symbol != ' ')
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
