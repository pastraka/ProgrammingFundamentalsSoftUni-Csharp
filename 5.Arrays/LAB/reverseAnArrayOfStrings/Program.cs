using System;
using System.Linq;

namespace reverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < n.Length / 2; i++)
            {
                SwapElements(n, i, n.Length - 1 - i);
            }
                Console.WriteLine(string.Join(" ", n));
        }

        static void SwapElements(string[] arr, int i, int j)
        {
            var oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;

        }
    }
}
