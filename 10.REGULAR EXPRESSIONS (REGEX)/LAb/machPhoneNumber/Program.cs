using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace machPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            string regex = @"(^| )\+359{1}([- ]){1}2{1}(\2)\d{3}(\2)\d{4}\b";

            MatchCollection phoneMatches = Regex.Matches(phoneNumbers, regex);

            string[] matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
