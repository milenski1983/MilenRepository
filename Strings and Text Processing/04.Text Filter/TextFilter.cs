using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Text_Filter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string regExp = Console.ReadLine();
            string[] regExpArray = regExp.Split(new char[]{',',' '},StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            StringBuilder inputSB = new StringBuilder(input);
            
            string result = input;
            foreach (string pattern in regExpArray)
            {
                Regex regex = new Regex(pattern);
                string replacement = new string('*',pattern.Length);
                result = regex.Replace(result, replacement);
            }
            Console.WriteLine(result);
        }
    }
}
