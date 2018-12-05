using System;
using System.Text.RegularExpressions;

namespace snowFlake
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = string.Empty;

            string surfacePattern = "^[^A-Za-z0-9]+$";
            string mantlePattern = "^[0-9_]+$";
            string multiPattern = "^([^A-Za-z0-9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";

            bool isAllFine = true;
            int coreLenght = -1;

            for (int i = 1; i <= 5; i++)
            {
                lines = Console.ReadLine();

                string currentPattern = string.Empty;

                if (i == 1 || i == 5)
                {
                    currentPattern = surfacePattern;
                }
                else if (i == 2 || i == 4)
                {
                    currentPattern = mantlePattern;
                }
                else
                {
                    currentPattern = multiPattern;
                }

                Regex regex = new Regex(currentPattern);

                if (regex.IsMatch(lines) && i == 3)
                {
                    coreLenght = regex.Match(lines).Groups["core"].Value.Length;
                }
                if (regex.IsMatch(lines) == false)
                {
                    isAllFine = false;
                }
            }

            if (isAllFine)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(coreLenght);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
