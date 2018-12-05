using System;

namespace gameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    combinations++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = { magicNum}");
                        return;
                    }
                }
            }
            Console.WriteLine
                   ($"{combinations} combinations - neither equals {magicNum}");
        }
    }
}
