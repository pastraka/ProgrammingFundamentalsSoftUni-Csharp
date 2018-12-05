using System;

namespace chooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            //string profession = input.ToLower();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;
            if (profession == "Athlete")
            {
                price = quantity * water;
                Console.WriteLine($"The {profession} has to pay {price:f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = quantity * coffee;
                Console.WriteLine($"The {profession} has to pay {price:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                price = quantity * beer;
                Console.WriteLine($"The {profession} has to pay {price:f2}.");
            }
            else
            {
                price = quantity * tea;
                Console.WriteLine($"The {profession} has to pay {price:f2}.");
            }
        }
    }
}
