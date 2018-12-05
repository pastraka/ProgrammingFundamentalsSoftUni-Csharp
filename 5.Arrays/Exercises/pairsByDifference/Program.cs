using System;
using System.Linq;

namespace pairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] - arr[i] == diff || arr[i] - arr[j] == diff)
                    {
                        count++;
                    }
                }
            }
                Console.WriteLine(count);
        }
    }
}
