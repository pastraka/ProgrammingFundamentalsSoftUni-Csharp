using System;

namespace signOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = PrintSign(n);
            Console.WriteLine($"The number {n} is {result}.");
        }

        static string PrintSign(int num)
        {
            if (num > 0)
            {
                return "positive";
            }
            else if (num < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }
    }
}
