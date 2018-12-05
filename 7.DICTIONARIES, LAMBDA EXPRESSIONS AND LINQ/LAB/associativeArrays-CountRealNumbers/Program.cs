using System;
using System.Collections.Generic;
using System.Linq;

namespace associativeArrays_CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            //sort
            while (true)
            {
                bool wasManip = false;
                for (int i = 0; i < input.Count - 1; i++)
                {
                    double curr = input[i];
                    double next = input[i + 1];

                    if (curr > next)
                    {
                        input[i] = input[i + 1];
                        input[i + 1] = curr;
                        wasManip = true;
                    }
                }
                if (wasManip == false)
                {
                    break;
                }
            }

            //counting Stars

            int count = 1;
            double current = input[0];

            for (int i = 1; i < input.Count; i++)
            {
                double next = input[i];
                if (current == next)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{current} -> {count}");
                    count = 1;
                    current = input[i];
                }
            }
            Console.WriteLine($"{current} -> {count}");
        }
    }
}
