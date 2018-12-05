using System;
using System.Collections.Generic;
using System.Linq;

namespace mobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }

                string[] tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (tokens[1] != "vs")
                {
                    string user = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    if (players.ContainsKey(user) == false)
                    {
                        players.Add(user, new Dictionary<string, int>());
                        players[user].Add(position, skill);
                    }
                    else if (players[user].ContainsKey(position) == false)
                    {
                        players[user].Add(position, 0);
                    }
                    if (players[user][position] < skill)
                    {
                        players[user][position] = skill;
                    }
                }
                else
                {
                    string player1 = tokens[0];
                    string player2 = tokens[2];

                    if (players.ContainsKey(player1) == false || players.ContainsKey(player2) == false)
                    {
                        continue;
                    }

                    bool common = false;

                    foreach (var item in players[player1])
                    {
                        if (players[player2].ContainsKey(item.Key))
                        {
                            common = true;
                        }
                    }
                    int totalSkill1 = 0;
                    int totalSkill2 = 0;

                    if (common)
                    {
                        totalSkill1 = players[player1].Values.Sum();
                        totalSkill2 = players[player2].Values.Sum();
                    }
                    if (totalSkill1 > totalSkill2)
                    {
                        players.Remove(player2);
                    }
                    else if (totalSkill2 > totalSkill1)
                    {
                        players.Remove(player1);
                    }
                }
            }
            foreach (var item in players.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");

                foreach (var position in item.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
