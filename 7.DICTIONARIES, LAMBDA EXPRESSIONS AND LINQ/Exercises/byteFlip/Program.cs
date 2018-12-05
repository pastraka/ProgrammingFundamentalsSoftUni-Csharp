using System;
using System.Collections.Generic;
using System.Linq;

namespace byteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Where(x => x.Length == 2).ToArray();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char[] charArr = input[i].ToArray();
                Array.Reverse(charArr);
                Console.Write(System.Convert.ToChar(System.Convert.ToInt32(new string(charArr), 16)));
            }
            Console.WriteLine();
        }
    }
}
