using System;

namespace stringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object result = ($"{a} {b}");
            Console.WriteLine(result);
        }
    }
}
