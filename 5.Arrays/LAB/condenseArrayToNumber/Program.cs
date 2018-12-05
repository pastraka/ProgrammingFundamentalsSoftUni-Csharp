using System;
using System.Linq;

namespace condenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condense = new int[arr.Length - 1];

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < condense.Length - i; j++)
                {
                    condense[j] = arr[j] + arr[j + 1];
                }
                arr = condense;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
