 using System;

namespace drawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigure(n);
        }

        static void PrintFigure(int n)
        {
            PrintHeader(n);
            PrintMiddle(n);
            PrintBottom(n);
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddle(int n)
        {
            for (int j = 1; j < n - 1; j++)
            {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");

            }
        }

        static void PrintBottom(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        

    }
}
