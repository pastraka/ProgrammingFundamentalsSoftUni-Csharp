using System;

namespace beverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());
            double totalEnergy = (volume * energyContent) / 100;
            double totalSugar = (volume * sugarContent) / 100;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
