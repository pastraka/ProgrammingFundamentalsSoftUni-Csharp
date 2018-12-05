using System;
using System.Text.RegularExpressions;

namespace traineGram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Traincode!")
            {
                //var match = Regex.Match(input, @"(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*\]\.)*$");

                if (Regex.IsMatch(input, @"^(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*\]\.)*$"))
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
