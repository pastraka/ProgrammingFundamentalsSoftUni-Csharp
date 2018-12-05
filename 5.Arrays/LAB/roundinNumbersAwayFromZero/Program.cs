using System;
using System.Linq;

namespace roundinNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            double[] nums = n.Split(' ')
                .Select(double.Parse)
                .ToArray();
            double[] arr = n.Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {arr[i]}");
            }
        }
    }
}
