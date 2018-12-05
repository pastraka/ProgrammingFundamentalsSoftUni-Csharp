using System;
using System.Collections.Generic;
using System.Linq;

namespace trainLands
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> trains = new Dictionary<string, Dictionary<string, int>>();

            while (command != "It's Training Men!")
            {
                string[] info = command.Split();

                if (info.Length == 5)
                {
                    string name = info[0];
                    string wagon = info[2];
                    int power = int.Parse(info[4]);
                    
                    if (trains.ContainsKey(name) == false)
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        current.Add(wagon, power);
                        trains.Add(name, current);
                    }
                    else
                    {
                        if (trains[name].ContainsKey(wagon) == false)
                        {
                            trains[name].Add(wagon, power);
                        }
                    }
                }
                else if (info[1] == "->")
                {
                    string first = info[0];
                    string other = info[2];

                    if (trains.ContainsKey(first) == false)
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        trains.Add(first, current);
                    }

                    foreach (var pair in trains[other])
                    {
                        trains[first].Add(pair.Key, pair.Value);
                    }
                    trains.Remove(other);
                }
                else
                {
                    string first = info[0];
                    string other = info[2];
                    if (trains.ContainsKey(first) == false)
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        trains.Add(first, current);
                    }
                    trains[first].Clear();
                    foreach (var pair in trains[other])
                    {
                        trains[first].Add(pair.Key, pair.Value);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var train in trains.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Values.Count))
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var item in train.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{item.Key} - {item.Value}");
                }
            }
        }
    }
}
