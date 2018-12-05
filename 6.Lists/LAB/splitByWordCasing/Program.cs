using System;
using System.Collections.Generic;

namespace splitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",;:.!( )\"\'\\/[ ] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> mixed = new List<string>();
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                if (IsLower(curr))
                {
                    lower.Add(curr);
                }
                else if (IsUpper(curr))
                {
                    upper.Add(curr);
                }
                else
                {
                    mixed.Add(curr);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lower));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upper));
        }

        static bool IsUpper(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'A' || 'Z' < symbol)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLower(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || 'z' < symbol)
                {
                    return false;
                }
            }
            return true;
        }
    }
}