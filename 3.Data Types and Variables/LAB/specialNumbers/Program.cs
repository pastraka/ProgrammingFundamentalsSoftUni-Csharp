﻿using System;

namespace specialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digit = num;
                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }
                bool special = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
                Console.WriteLine($"{num} -> {special}");
            }
        }
    }
}
