using System;

namespace exchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before: ");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            int temprorary = b;
            b = a;
            a = temprorary;
            Console.WriteLine("After: ");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
