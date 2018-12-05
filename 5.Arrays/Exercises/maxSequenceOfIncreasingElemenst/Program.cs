using System;
using System.Linq;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int currentLength = 1;
            int bestLength = 1;
            int bestStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = start;
                    }

                }
                else
                {
                    currentLength = 1;
                    start = i;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}