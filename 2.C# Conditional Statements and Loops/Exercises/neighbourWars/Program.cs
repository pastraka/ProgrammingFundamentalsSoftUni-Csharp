using System;

namespace neighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            string peshoKick = "Roundhouse kick";
            string goshoKick = "Thunderous fist";
            string name1 = "Pesho";
            string name2 = "Gosho";
            int counter = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    counter += 1;
                    goshoHealth -= peshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"{name2} won in {counter}th round.");
                        return;
                    }
                    else if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"{name1} won in {counter}th round.");
                        return;
                    }
                    Console.WriteLine
                      ($"{name1} used {peshoKick} and reduced {name2} to {goshoHealth} health.");
                }
                else if (i % 2 == 0)
                {
                    counter += 1;
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"{name2} won in {counter}th round.");
                        return;
                    }
                    else if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"{name1} won in {counter}th round.");
                        return;
                    }
                    Console.WriteLine
                     ($"{name2} used {goshoKick} and reduced {name1} to {peshoHealth} health.");
                }
                if (counter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}