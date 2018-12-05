using System;
using System.Collections.Generic;
using System.Linq;

namespace magicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string line1 = input[0];
            string line2 = input[1];

            //HashSet<char> str1 = new HashSet<char>(input[0]);
            //HashSet<char> str2 = new HashSet<char>(input[1]);

            //Console.WriteLine((str1.Count == str2.Count) ? "true" : "false");


            Boolean result = IsExchangeable(line1, line2);

            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static bool IsExchangeable(string line1, string line2)
        {
            bool IsExchangeable = false;
            char[] str1 = line1.Distinct().ToArray();
            char[] str2 = line2.Distinct().ToArray();

            if (str1.Length == str2.Length)
            {
                IsExchangeable = true;
            }
            return IsExchangeable;
        }
    }
}
