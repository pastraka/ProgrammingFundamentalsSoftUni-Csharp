using System;
using System.Numerics;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger number = 1;
            BigInteger result = GetFactorial(n, number);

            Console.WriteLine(result);
        }

        static BigInteger GetFactorial(int n, BigInteger number)
        {
            number = 1;
            do
            {
                number = number * n;
                n--;
            }
            while (n > 1);
            return number;
        }
    }
}
