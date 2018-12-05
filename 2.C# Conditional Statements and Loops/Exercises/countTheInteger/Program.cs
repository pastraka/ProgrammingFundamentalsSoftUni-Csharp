﻿using System;

namespace countTheInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out int number);
                if (isNumber)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
