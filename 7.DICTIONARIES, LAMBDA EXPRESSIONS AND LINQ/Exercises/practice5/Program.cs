using System;
using System.Collections.Generic;
using System.Linq;

namespace practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine()
                .Split()
                .OrderBy(t => t)
                .ToList();

            Console.WriteLine(string.Join(", ", times));


        }
    }
}
