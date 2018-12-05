using System;

namespace variableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(input);
        }
    }
}
