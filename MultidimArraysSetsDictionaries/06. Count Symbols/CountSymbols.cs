using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Count_Symbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<char> chars = new HashSet<char>(input);
            List<char> symbols = new List<char>(chars);
            symbols.Sort();
            
            foreach (char symbol in symbols)
            {
                int symbolsCounter = 0;
                foreach (char item in input)
                {
                    if (item == symbol)
                    {
                        symbolsCounter++;
                    }
                }
                Console.WriteLine(symbolsCounter == 1 ? symbol + ": 1 time" : symbol + ": " + symbolsCounter + " times");
            }
        }
    }
}
