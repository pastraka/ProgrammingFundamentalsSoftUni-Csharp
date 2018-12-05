using System;
using System.Collections.Generic;
using System.Linq;

namespace practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> evenNum = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenNum.Add(arr[i]);
                }
            }
            double average = evenNum.Average();

            for (int i = 0; i < evenNum.Count; i++)
            {
                if (evenNum[i] > average)
                {
                    evenNum[i]++;
                }
                else
                {
                    evenNum[i]--;
                }
            }
            Console.WriteLine(string.Join(" ", evenNum));
        }
    }
}

