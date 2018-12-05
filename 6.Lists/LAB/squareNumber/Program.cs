using System;
using System.Collections.Generic;
using System.Linq;

namespace squareNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> squares = new List<int>();

            for (int i = 0; i < number.Count; i++)
            {
                int curr = number[i];
                double square = Math.Sqrt(curr);
                int whole = (int)square;
                if (square == whole)
                {
                    squares.Add(curr);
                }
            }
            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
