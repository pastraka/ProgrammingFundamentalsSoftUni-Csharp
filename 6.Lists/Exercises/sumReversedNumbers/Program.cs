﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace sumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int reverse = 0;

                while (input[i] > 0)
                {
                    int r = input[i] % 10;
                    reverse = reverse * 10 + r;
                    input[i] = input[i] / 10;
                }
                sum += reverse;
            }
            Console.WriteLine(sum);
        }
    }
}
