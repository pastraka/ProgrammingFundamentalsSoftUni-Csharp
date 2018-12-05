using System;
using System.Collections.Generic;
using System.Linq;

namespace codePhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            //creature -> squadMate

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Blaze it!")
                {
                    break;
                }

                string[] line = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string creature = line[0];
                string squadMate = line[1];

                if (heroes.ContainsKey(creature) == false)
                {
                    heroes.Add(creature, new List<string>());
                    heroes[creature].Add(squadMate);
                }
                else
                {
                    if (heroes[creature].Contains(squadMate) == false && squadMate != creature)
                    {
                        heroes[creature].Add(squadMate);
                    }
                }
            }
            foreach (var pair in heroes)
            {
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    if (heroes.ContainsKey(pair.Value[i]))
                    {
                        if (heroes[pair.Value[i]].Contains(pair.Key))
                        {
                            heroes[pair.Value[i]].Remove(pair.Key);
                            heroes[pair.Key].Remove(pair.Value[i]);
                            i--;
                        }
                    }
                }
            }
            foreach (var hero in heroes.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{hero.Key} : {hero.Value.Count}");
            }
        }
    }
}
