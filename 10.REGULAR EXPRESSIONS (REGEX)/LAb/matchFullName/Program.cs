using System;
using System.Text.RegularExpressions;

namespace matchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

            MatchCollection matchedNames = Regex.Matches(names, pattern);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
