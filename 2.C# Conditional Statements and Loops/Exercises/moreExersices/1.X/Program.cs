using System;

namespace _1.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var spaceRight = 0;
            var midSpace = n - 2;

            for (int row = 0; row < n / 2; row++)
            { 
                for (int i = 0; i <= spaceRight; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int i = 0; i < midSpace - spaceRight; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();
                spaceRight++;
                midSpace--;
            }
            string middleSpace = new string(' ', n / 2 + 1);
            Console.WriteLine(middleSpace + "x");
            for (int row = 0; row < n / 2; row++)
            {
                for (int i = 0; i <= midSpace; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int i = 0; i < spaceRight - midSpace; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();
                spaceRight++;
                midSpace--;
            }

        }
    }
}
