using System;
using System.Collections.Generic;
using System.Linq;

namespace pokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string name;
            string type;
            int index;

            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

            while (input[0] != "wubbalubbadubdub")
            {
                if (input.Length > 1)
                {
                    name = input[0];
                    type = input[1];
                    index = int.Parse(input[2]);
                    string evolution = type + " <-> " + index;
                    if (pokemons.ContainsKey(name) == false)
                    {
                        List<string> current = new List<string>();
                        current.Add(evolution);
                        pokemons.Add(name, current);
                    }
                    else
                    {
                        pokemons[name].Add(evolution);
                    }
                }
                else
                {
                    name = input[0];
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var item in pokemons[name])
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                input = Console.ReadLine().Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var pair in pokemons)
            {
                Console.WriteLine($"# {pair.Key}");
                foreach (var evo in pair.Value.OrderByDescending(x => int.Parse(x.Split("->< ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Skip(1).Last())))
                {
                    Console.WriteLine(evo);
                }
            }
        }
    }
}
