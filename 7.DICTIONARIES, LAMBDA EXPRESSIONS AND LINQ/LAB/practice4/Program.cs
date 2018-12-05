using System;
using System.Linq;

namespace practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(" ", nums.OrderByDescending(x => x).Take(3)));
        }
    }
}
