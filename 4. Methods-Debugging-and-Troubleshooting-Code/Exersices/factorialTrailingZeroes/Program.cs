using System;
using System.Numerics;

namespace factorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger number = 0;
            BigInteger result = GetFactorial(n, number);
            BigInteger countZeroes = CountZeroes(result);
            Console.WriteLine(countZeroes);
        }

        static BigInteger GetFactorial(int n, BigInteger number)
        {
            number = 1;
            for (int i = 1; i <= n; i++)
            {
                number *= i;
            }
            return number;
        }

        static BigInteger CountZeroes(BigInteger result)
        {
            int count = 0;
            while (result % 10 == 0)
            {
                BigInteger num = result % 10;
                if (num % 10 == 0)
                    count++;
                result /= 10;
            }
            return count;
        }
    }
}
