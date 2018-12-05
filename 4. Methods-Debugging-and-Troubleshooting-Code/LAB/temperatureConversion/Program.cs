using System;

namespace temperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            double celsius = PrintFarhToCelsius(degrees);
            PrintFarhToCelsius(degrees);
            Console.WriteLine($"{celsius:f2}");
        }

        static double PrintFarhToCelsius (double degrees)
        {
            double celsius = (degrees - 32) * 5 / 9;
            return celsius;
        }
    }
}
