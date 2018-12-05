using System;
using System.Collections.Generic;
using System.Linq;

namespace ironGirder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<int, int>> schedule = new Dictionary<string, Dictionary<int, int>>();
            string input = Console.ReadLine();

            while (input != "Slide rule")
            {
                string[] line = input.Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string townName = line[0];
                string[] text = line[1].Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string timeAmbush = text[0];
                int passengerCount = int.Parse(text[1]);

                if (timeAmbush != "ambush")
                {
                    int time = int.Parse(timeAmbush);
                    if (schedule.ContainsKey(townName) == false)
                    {
                        schedule.Add(townName, new Dictionary<int, int>());
                    }

                    if (schedule[townName].ContainsKey(time) == false)
                    {
                        schedule[townName].Add(time, passengerCount);
                    }
                    schedule[townName][time] += passengerCount;

                    if (schedule[townName][time] > time)
                    {
                        schedule[townName][time] = time;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}
