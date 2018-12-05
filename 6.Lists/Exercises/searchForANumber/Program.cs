using System;
using System.Collections.Generic;
using System.Linq;

namespace searchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> newList = new List<int>();

            for (int i = 0; i < arr[0]; i++)
            {
                newList.Add(nums[i]);
            }
            newList.RemoveRange(0, arr[1]);

            if (newList.Contains(arr[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
