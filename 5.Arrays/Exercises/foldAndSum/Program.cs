using System;
using System.Linq;

namespace foldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int k = arr1.Length / 4;
            //int[] arr3 = new int[2 * k];

            ////right end array

            //for (int i = 0; i < k; i++)
            //{
            //    arr3[i] = arr1[k - 1 - i];
            //    arr3[k + i] = arr1[4 * k - 1 - i];
            //}

            ////second middle array

            //int[] arr2 = new int[2 * k];

            //for (int i = 0; i < 2 * k; i++)
            //{
            //    arr2[i] = arr1[i + k];
            //    Console.Write($"{arr3[i] + arr2[i]} ");
            //}
            //Console.WriteLine();

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] left = GetPart(arr, k, 0);
            int[] middle = GetPart(arr, 2 * k, k);
            int[] right = GetPart(arr, k, 3 * k);

            Array.Reverse(left);
            Array.Reverse(right);
            int[] merged = new int[2 * k];

            int index = 0;
            for (int i = 0; i < k; i++)
            {
                merged[index++] = left[i];
            }

            for (int i = 0; i < k; i++)
            {
                merged[index++] = right[i];
            }

            for (int i = 0; i < middle.Length; i++)
            {
                int sum = middle[i] + merged[i];
                Console.Write($"{sum} ");
            }
            Console.WriteLine();
        }

        static int[] GetPart(int[] arr, int size, int startIndex)
        {
            int[] part = new int[size];
            for (int i = startIndex; i < size + startIndex; i++)
            {
                part[i - startIndex] = arr[i];
            }
            return part;
        }
    }
}
