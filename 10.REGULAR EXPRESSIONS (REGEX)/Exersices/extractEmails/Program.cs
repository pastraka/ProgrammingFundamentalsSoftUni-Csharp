using System;
using System.Text.RegularExpressions;

namespace extractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<= )[A-Za-z0-9]+([.\-_][A-Za-z0-9]+)*@[A-Za-z]+([\-A-Za-z]+)*(\.[A-Za-z]+)+";

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            foreach (Match email in matches)
            {
                Console.WriteLine(email);
            }
        }
    }
}
