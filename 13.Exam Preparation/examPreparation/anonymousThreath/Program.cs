using System;
using System.Collections.Generic;
using System.Linq;

namespace anonymousThreath
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "3:1")
                {
                    break;
                }

                string[] tokens = line.Split().ToArray();
                if (tokens[0] == "merge")
                {
                    int starttIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    string concatWord = string.Empty;

                    for (int i = starttIndex; i <= endIndex; i++)
                    {
                        concatWord += words[i];
                    }

                    words.RemoveRange(starttIndex, endIndex - starttIndex + 1);
                    words.Insert(starttIndex, concatWord);
                }
                else if (tokens[0] == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                }
            }
        }
    }
}
