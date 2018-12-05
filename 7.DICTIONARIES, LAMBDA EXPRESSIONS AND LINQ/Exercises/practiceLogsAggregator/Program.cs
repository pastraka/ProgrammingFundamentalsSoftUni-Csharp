using System;
using System.Collections.Generic;
using System.Linq;

namespace practiceLogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();
                string ipAddress = tokens[0];
                string name = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (logs.ContainsKey(name) == false)
                {
                    logs.Add(name, new SortedDictionary<string, int>());
                }
                if (logs[name].ContainsKey(ipAddress) == false)
                {
                    logs[name].Add(ipAddress, duration);
                }
                else
                {
                    logs[name][ipAddress] += duration;
                }
            }
            foreach (var user in logs)
            {
                int totalDuration = logs[user.Key].Values.Sum();

                List<string> ipS = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalDuration} [{string.Join(", ", ipS)}]");
            }
        }
    }
}
