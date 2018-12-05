using System;
using System.Collections.Generic;

namespace karateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string output = string.Empty;
            int power = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    power += int.Parse(line[i + 1].ToString());
                }
                else if (power > 0)
                {
                    power--;
                    continue;
                }
                output += line[i];
            }

            Console.WriteLine(output);
        }
    }
}
