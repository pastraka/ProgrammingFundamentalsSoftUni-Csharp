using System;
using System.Linq;

namespace sumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lengthArr = Math.Max(arr1.Length, arr2.Length);
            int[] sumArray = new int[lengthArr];

            for (int i = 0; i < lengthArr; i++)
            {
                sumArray[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
