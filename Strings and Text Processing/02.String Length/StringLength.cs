using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.String_Length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length >= 20)
            {
                Console.WriteLine(input.Substring(0, 20));
            }
            else
	        {
                Console.WriteLine(input.PadRight(20, '*'));
	        }
        }
    }
}
