using System;

namespace charecterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            
            //Name
            Console.WriteLine($"Name: {name}");
            
            //HealthBar
            int remainingHealth = maxHealth - currentHealth;
            string currentHealthAsString = new string('|', currentHealth);
            string remainingHealthAsString = new string('.', remainingHealth);
            string healthBar = $"Health: |{currentHealthAsString}{remainingHealthAsString}|";

            Console.WriteLine(healthBar);

            //EnergyBar
            int remainingEnergy = maxEnergy - currentEnergy;
            string currentEnergyAsString = new string('|', currentEnergy);
            string remainingEnergyAsString = new string('.', remainingEnergy);
            string energyBar = $"Energy: |{currentEnergyAsString}{remainingEnergyAsString}|";

            Console.WriteLine(energyBar);
        }
    }
}
