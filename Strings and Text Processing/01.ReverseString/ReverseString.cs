using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = new char[input.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = input[input.Length - 1 - i];
            }
            Console.WriteLine(string.Join("",charArray));
        }
    }
}
