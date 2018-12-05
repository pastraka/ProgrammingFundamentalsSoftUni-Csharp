using System;
using System.Linq;

namespace practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = nums.Length / 4;
            int[] rowLeft = nums.Take(k).Reverse().ToArray();
            int[] rowMiddle = nums.Take(2 * k).ToArray();
            int[] rowRight = nums.Take(k).Reverse().ToArray();
        }
    }
}
