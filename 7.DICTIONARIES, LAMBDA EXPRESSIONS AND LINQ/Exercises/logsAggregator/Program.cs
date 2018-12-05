using System;
using System.Collections.Generic;
using System.Linq;

namespace logsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> users = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <  n; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();
                string ipAddress = tokens[0];
                string userName = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (users.ContainsKey(userName) == false)
                {
                    users.Add(userName, new SortedDictionary<string, int>());
                }  

                if (users[userName].ContainsKey(ipAddress) == false)
                {
                    users[userName].Add(ipAddress, duration);
                }
                else
                {
                    users[userName][ipAddress] += duration;
                }
            }
            foreach (var person in users)
            {
                int totalDuration = users[person.Key].Values.Sum();

                List<string> ipS = person.Value.Keys.ToList();

                Console.WriteLine($"{person.Key}: {totalDuration} [{string.Join(", ", ipS)}]");
            }
        }
    }
}
