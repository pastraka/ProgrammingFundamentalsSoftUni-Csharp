﻿using System;
using System.Text.RegularExpressions;

namespace keyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            string keyPattern = @"^([a-zA-Z]*)[\\<|].{0,}[\\<|]([a-zA-Z]*)$";

            Match keyMatches = Regex.Match(key, keyPattern);

            string startPattern = keyMatches.Groups[1].Value;
            string endPattern = keyMatches.Groups[2].Value;

            string textPattern = @"(" + startPattern + @"(.{0,}?)" + endPattern + @")";

            string result = "";

            foreach (Match item in Regex.Matches(text, textPattern))
            {
                result += item.Groups[2].Value;
            }

            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
