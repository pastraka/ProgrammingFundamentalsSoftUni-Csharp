﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(".,!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                bool isPalindrom = IsPalindrom(word);

                if (isPalindrom)
                {
                    palindromes.Add(word);
                }
            }
            var sorted = palindromes.Distinct().OrderBy(w => w);

            Console.WriteLine(string.Join(", ", sorted));
        }

        static bool IsPalindrom(string word)
        {
            string reveresed = new string(word.Reverse().ToArray());

            return String.Equals(reveresed, word);
        }
    }
}
