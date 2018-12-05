using System;

namespace cakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                string product = Console.ReadLine();
                if (product != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {product}.", Environment.NewLine);
                    count += 1;
                } else
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    return;
                }
            }
        }
    }
}
