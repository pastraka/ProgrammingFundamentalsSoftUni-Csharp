using System;
using System.Collections.Generic;
using System.Linq;

namespace snowMen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmenInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (snowmenInput.Count != 1)
            {
                List<int> snowmenToRemove = new List<int>();

                for (int i = 0; i < snowmenInput.Count; i++)
                {
                    int attackerIndex = i;

                    if (snowmenToRemove.Contains(attackerIndex))
                    {
                        continue;
                    }

                    int targetIndex = snowmenInput[i] % snowmenInput.Count;
                    int looserIndex = -1;

                    if (attackerIndex == targetIndex)
                    {
                        looserIndex = attackerIndex;
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                    }
                    else
                    {
                        int winerIndex = -1;

                        int difference = Math.Abs(attackerIndex - targetIndex);
                        if (difference % 2 == 0)
                        {
                            winerIndex = attackerIndex;
                            looserIndex = targetIndex;
                        }
                        else
                        {
                            winerIndex = targetIndex;
                            looserIndex = attackerIndex;
                        }

                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {winerIndex} wins");
                    }

                    if (snowmenToRemove.Contains(looserIndex) == false)
                    {
                        snowmenToRemove.Add(looserIndex);
                    }

                    if (snowmenInput.Count == snowmenToRemove.Count + 1)
                    {
                        break;
                    }
                }

                snowmenInput = ClearSnowmen(snowmenInput, snowmenToRemove.OrderByDescending(m => m).ToList());
            }
        }

        private static List<int> ClearSnowmen(List<int> snowmenInput, List<int> snowmenToRemove)
        {
            for (int i = 0; i < snowmenToRemove.Count; i++)
            {
                snowmenInput.RemoveAt(snowmenToRemove[i]);
            }

            return snowmenInput;
        }
    }
}
