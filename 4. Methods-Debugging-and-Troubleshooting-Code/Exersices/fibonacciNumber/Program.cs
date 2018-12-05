using System;

namespace fibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = Fabonacci(n);
            Console.WriteLine(result);
        }

        static int Fabonacci(int n)
        {
            int fnext = 0;
            int f1 = 0;
            int f2 = 1;
            for (int i = 0; i < n; i++)
            {
                 fnext = f1 + f2;
                f1 = f2;
                f2 = fnext;
            }
            return f2;
        }
    }
}
