using System;

namespace chooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string profession = input.ToLower();

            if (profession == "athlete")
            {
                Console.WriteLine("Water");
            } else if (profession == "businessman" || profession == "businesswoman")
            {
                Console.WriteLine("Coffee");
            } else if (profession == "softuni student")
            {
                Console.WriteLine("Beer");
            } else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
