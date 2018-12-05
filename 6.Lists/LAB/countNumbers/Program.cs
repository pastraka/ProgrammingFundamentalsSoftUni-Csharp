using System;
using System.Collections.Generic;
using System.Linq;

namespace countNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();

            int count = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                    count = 1;
                }
            }
            Console.WriteLine($"{numbers[numbers.Count - 1]} -> {count}");


            //int[] counter = new int[1001];

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int index = numbers[i];
            //    counter[index]++;
            //}

            //for (int i = 0; i < counter.Length; i++)
            //{
            //    if(counter[i] != 0)
            //    {
            //        Console.WriteLine($"{i} -> {counter[i]}");
            //    }
            //}
        }
    }
}
