using System;

namespace multiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdds = GetMultipleOdds(n);
            int sumEven = GetMultipleEven(n);
            int result = GetMultipleSumOfEvensByOdds(n);
            Console.WriteLine(result);
        }

        static int GetMultipleSumOfEvensByOdds(int n)
        {
            int sumOdds = GetMultipleOdds(n);
            int sumEven = GetMultipleEven(n);
            return sumOdds * sumEven;
        }

        static int GetMultipleOdds(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;

        }

        static int GetMultipleEven(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;

        }
    }
}
