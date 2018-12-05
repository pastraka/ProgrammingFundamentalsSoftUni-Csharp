﻿using System;

namespace vaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine());

            decimal sum = currentBalance;
            decimal price = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "OutFall 4")
                    price = (decimal)39.99;
                else if (command == "CS: OG")
                {
                    price = (decimal)15.99;
                }
                else if (command == "Zplinter Zell")
                {
                    price = (decimal)19.99;
                }
                else if (command == "Honored 2")
                {
                    price = (decimal)59.99;
                }
                else if (command == "RoverWatch")
                {
                    price = (decimal)29.99;
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    price = (decimal)39.99;
                }
                else if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${sum - currentBalance:f2}. Remaining: ${currentBalance:f2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                currentBalance -= price;

                if (currentBalance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    currentBalance += price;
                }
                else if (currentBalance >= 0)
                {
                    Console.WriteLine($"Bought {command}");
                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
            }
        }
    }
}
