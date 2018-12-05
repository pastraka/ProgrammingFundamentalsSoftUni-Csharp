using System;

namespace indexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();

            for (int i = 0 ; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} -> {arr[i] - 'a'}");
            }
        }
    }
}
