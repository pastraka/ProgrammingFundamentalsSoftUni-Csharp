using System;
using System.Collections.Generic;
using System.Linq;

namespace largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", input.OrderByDescending(x => x).Take(3)));
        }
    }
}
