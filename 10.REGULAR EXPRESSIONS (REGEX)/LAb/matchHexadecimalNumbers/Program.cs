using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace matchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?:0x)?[0-9A-F]+\b";

            string input = Console.ReadLine();
            string[] nums = Regex.Matches(input, regex).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
