using System;
using System.Collections.Generic;
using System.Linq;

namespace grainsOfSands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grains = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Mort")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "Add")
                {
                    int value = int.Parse(tokens[1]);
                    grains.Add(value);
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(tokens[1]);
                    if (grains.Contains(value))
                    {
                        grains.Remove(value);
                    }
                    else
                    {
                        if (grains.ElementAtOrDefault(value) != 0)
                        {
                            grains.RemoveAt(value);

                        }
                    }
                }

                else if (command == "Replace")
                {
                    int value = int.Parse(tokens[1]);
                    int replacement = int.Parse(tokens[2]);

                    if (grains.Contains(value))
                    {
                        int indexValue = grains.IndexOf(value);

                        grains.RemoveAt(indexValue);
                        grains.Insert(indexValue, replacement);
                    }
                }
                else if (command == "Increase")
                {
                    int value = int.Parse(tokens[1]);

                    bool found = false;
                    foreach (var grain in grains)
                    {
                        if (grain >= value)
                        {
                            value = grain;
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                    {
                        value = grains.Last();
                    }

                    for (int index = 0; index < grains.Count; index++)
                    {
                        grains[index] += value;
                    }
                }
                else if (command == "Collapse")
                {
                    int value = int.Parse(tokens[1]);
                    grains.RemoveAll(e => e < value);
                }
            }
            Console.WriteLine(string.Join(" ", grains));
        }
    }
}
