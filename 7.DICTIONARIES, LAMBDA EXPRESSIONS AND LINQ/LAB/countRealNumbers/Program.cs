﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace countRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 0);
                }
                numbers[num]++;
            }
            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value} times");
            }
        }
    }
}
