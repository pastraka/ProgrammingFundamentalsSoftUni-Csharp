using System;

namespace oddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                } else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(num));
                    break;
                }

            }

            
        }
    }
}
