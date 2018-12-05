using System;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Getname();
            Console.WriteLine($"Hello, {name}!");

        }

        static string Getname()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
