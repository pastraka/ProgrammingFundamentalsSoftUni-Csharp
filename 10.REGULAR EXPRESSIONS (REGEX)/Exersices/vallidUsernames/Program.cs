using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace vallidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            List<string> list = new List<string>();

            int sum = 0;
            int maxSum = 0;
            string first = "";
            string second = "";

            for (int i = 1; i < matches.Count; i++)
            {
                sum = matches[i - 1].Length + matches[i].Length;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    first = matches[i - 1].ToString();
                    second = matches[i].ToString();
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
