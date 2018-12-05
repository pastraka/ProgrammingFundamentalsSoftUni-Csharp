using System;
using System.Collections.Generic;
using System.Linq;

namespace hornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input
            //{lastActivity} = {legionName} -> {soldierType}:{soldierCount} // input
            //store the legion with its activity and everu soldier type with its count in its legion
            //update activity every time i add new soldier if its > than the prev one 
            // command 

            Dictionary<string, Dictionary<string, long>> hornest = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> activities = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine();
                int activity = int.Parse(input[0]);
                string legion = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                //пълнене на речника и вложените речници 

                if (activities.ContainsKey(legion) == false)
                {
                    activities.Add(legion, activity);
                }
                else
                {
                    if (activities[legion] < activity)
                    {
                        activities[legion] = activity;
                    }
                }

                if (hornest.ContainsKey(legion) == false)
                {
                    Dictionary<string, long> current = new Dictionary<string, long>();
                    current.Add(soldierType, soldierCount);
                    hornest.Add(legion, current);
                }
                else
                {
                    if (hornest[legion].ContainsKey(soldierType) == false)
                    {
                        hornest[legion].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        hornest[legion][soldierType] += soldierCount;
                    }
                }
            }
            string[] command = Console.ReadLine().Split("\\ ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (command.Length == 1)
            {
                foreach (var pair in activities.OrderByDescending(x => x.Value))
                {
                    if (hornest[pair.Key].ContainsKey(command[0]))
                    {
                        Console.WriteLine($"{pair.Value} : {pair.Key}");
                    }
                }
            }
            else
            {
                int act = int.Parse(command[0]);
                string type = command[1];

                foreach (var pair in hornest.Where(x => x.Value.ContainsKey(type)).OrderByDescending(x => x.Value[type]))
                {
                    if (activities[pair.Key] < act)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value[type]}");
                    }
                }
            }
        }
    }
}
