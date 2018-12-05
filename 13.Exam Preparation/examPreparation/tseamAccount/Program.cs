using System;
using System.Collections.Generic;
using System.Linq;

namespace tseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> gameList = input.Split().ToList();

            string[] command = Console.ReadLine().Split(" -".ToCharArray());

            while (command[0] != "Play!")
            {

                if (command[0] == "Install")
                {
                    if (gameList.Contains(command[1]) == false)
                    {
                        gameList.Add(command[1]);
                    }
                }
                else if (command[0] == "Uninstall")
                {
                    if (gameList.Contains(command[1]))
                    {
                        gameList.Remove(command[1]);
                    }
                }
                else if (command[0] == "Update")
                {
                    if (gameList.Contains(command[1]))
                    {
                        gameList.Remove(command[1]);
                        gameList.Add(command[1]);
                    }
                }
                else if (command[0] == "Expansion")
                {
                    if (gameList.Contains(command[1]))
                    {
                        int index = gameList.IndexOf(command[1]);
                        string sorted = command[1] + ":" + command[2];
                        gameList.Insert(index + 1, sorted);
                    }
                }
                command = Console.ReadLine().Split(" -".ToCharArray());
            }
            Console.WriteLine(string.Join(" ", gameList));
        }
    }
}
