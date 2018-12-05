using System;
using System.Text.RegularExpressions;

namespace matchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string numStr = Console.ReadLine();

            MatchCollection nums = Regex.Matches(numStr, regex);

            foreach (Match num in nums)
            {
                Console.Write(num.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
