using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Unicode_Characters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char item in input)
            {
                Console.Write("\\u" + Convert.ToString(item, 16).PadLeft(4, '0'));
            }
        }
    }
}
