using System;
using System.Collections.Generic;
using System.Linq;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> nums = new SortedDictionary<double, int>();

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (nums.ContainsKey(numbers[i]) == false)
                {
                    nums.Add(numbers[i], 1);
                }
                else
                {
                    nums[numbers[i]]++;
                }
            }
            foreach (var n in nums)
            {
                Console.WriteLine($"{n.Key} -> {n.Value}");
            }
        }
    }
}
