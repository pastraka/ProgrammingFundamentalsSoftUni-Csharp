using System;
using System.Linq;
using System.Collections.Generic;

namespace removeNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(s => int.Parse(s))
                .Reverse()
                .ToList();

            //with lambda

            list.RemoveAll(x => x < 0);

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }


            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] < 0)
            //    {
            //        list.RemoveAt(i);
            //        i--;
            //    }
            //}
            //list.Reverse();
            //if (list.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(" ", list));
            //}
        }
    }
}
