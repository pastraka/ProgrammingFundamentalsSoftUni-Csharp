using System;

namespace milesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double km = 1.60934;
            double totalKm = miles * km;
            Console.WriteLine($"{totalKm:f2}");
        }
    }
}
