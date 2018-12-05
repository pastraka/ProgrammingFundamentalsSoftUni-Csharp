using System;
using System.Collections.Generic;
using System.Linq;

namespace forceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains("|"))
                {
                    string[] tokens = line.Split(" | ");
                    string side = tokens[0];
                    string user = tokens[1];

                    if (sides.ContainsKey(side) == false)
                    {
                        sides.Add(side, new List<string>());
                    }

                    if (sides.Values.Any(x => x.Contains(user)) == false)
                    {
                        sides[side].Add(user);
                    }
                }
                else
                {
                    string[] tokens = line.Split(" -> ");
                    string user = tokens[0];
                    string side = tokens[1];

                    if (sides.Values.Any(x => x.Contains(user)))
                    {
                        sides.Values.First(x => x.Contains(user)).Remove(user);
                        if (sides.ContainsKey(side) == false)
                        {
                            sides.Add(side, new List<string>());
                        }

                        sides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        if (sides.ContainsKey(side) == false)
                        {
                            sides.Add(side, new List<string>());
                        }

                        sides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }
            foreach (var item in sides.OrderByDescending(k => k.Value.Count).ThenBy(k => k.Key))
            {
                if (item.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                }

                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
