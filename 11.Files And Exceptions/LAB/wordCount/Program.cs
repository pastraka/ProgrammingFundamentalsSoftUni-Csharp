using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText(@"..\..\..\words.txt")
                .ToLower()
                .Split(" \r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] input = Regex.Split(File.ReadAllText(@"..\..\..\input.txt"),
                "[^A-Za-z0-9\']+")
                .Where(e => !e.Equals(""))
                .Select(e => e.ToLower())
                .ToArray();

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCount[word] = 0;
            }

            foreach (var word in input)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            List<string> result = new List<string>();
            foreach (var word in wordsCount.OrderByDescending(w => w.Value))
            {
                result.Add($"{word.Key} - {word.Value}");

            }

            File.AppendAllLines(@"..\..\..\output.txt", result);
        }
    }
}
