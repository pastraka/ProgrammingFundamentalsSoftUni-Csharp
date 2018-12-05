using System;

namespace emailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("@");
            string start = input[0];
            string end = input[1];

            //if (start.Length >= end.Length)
            //{
            //    Console.WriteLine("Call her!");
            //}
            //else
            //{
            //    Console.WriteLine("She is not the one.");
            //}
            int sumStart = 0;
            int sumEnd = 0;

            for (int i = 0; i < start.Length; i++)
            {
                sumStart = sumStart + start[i];
            }
            for (int i = 0; i < end.Length; i++)
            {
                sumEnd = sumEnd + end[i];
            }
            if (sumStart - sumEnd >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
