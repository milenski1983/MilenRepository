using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_Substring_Occurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regexpresion = Console.ReadLine();
            StringBuilder inputSB = new StringBuilder(input.ToLower());
            int occurrences = 0;
            int index;
            do
            {
                index = inputSB.ToString().IndexOf(regexpresion);
                if (index >= 0)
                {
                    occurrences++;
                    inputSB.Remove(index, regexpresion.Length);
                }
            } while (index >= 0);
            Console.WriteLine(occurrences);
        }
    }
}
