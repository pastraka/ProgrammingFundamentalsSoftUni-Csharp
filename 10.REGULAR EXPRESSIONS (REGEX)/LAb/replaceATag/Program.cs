using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace replaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(<a.*?\w*?.*?)=(.*?)>(.*?)(<\/a>)";

            string input = "";
            int rowCounter = 0;

            List<string> list = new List<string>();

            while (rowCounter < 100)
            {
                input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                MatchCollection match = Regex.Matches(input, regex);

                string replace = "[URL href=$2]$3[/URL]";

                string replaced = Regex.Replace(input, regex, replace);

                input = replaced;
                list.Add(input);
                rowCounter++;
            }

            Console.WriteLine(string.Join(Environment.NewLine, list));
            Console.WriteLine();
        }
    }
}
