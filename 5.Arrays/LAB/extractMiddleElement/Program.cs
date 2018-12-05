using System;
using System.Linq;

namespace extractMiddleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arr.Length;
            int[] result;
            var finalResult = "";
            if (n == 1)
            {
                result = new int[1];
                result[0] = arr[0];
            }
            else if (n % 2 == 0)
            {
                result = new int[2];
                result[0] = arr[n / 2 - 1];
                result[1] = arr[n / 2];
            }
            else
            {
                result = new int[3];
                result[0] = arr[n / 2 - 1];
                result[1] = arr[n / 2];
                result[2] = arr[n / 2 + 1];
            }
             finalResult = string.Join(", ", result);
            Console.WriteLine($"{{ {finalResult} }}");
        }
    }
}
