using System;
using System.Linq;

namespace tripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            int[] arr = numAsString.Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool isTriples = true;

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = 1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (arr[a] + arr[b] == arr[c])
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            isTriples = false;
                            break;
                        }
                    }
                }
            }
            if (isTriples == true)
            {
                Console.WriteLine("No");
            }
        }
    }
}
