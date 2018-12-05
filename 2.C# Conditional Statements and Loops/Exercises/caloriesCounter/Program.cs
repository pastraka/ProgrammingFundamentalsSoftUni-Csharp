using System;

namespace caloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int totalCalories = 0;
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string product = input.ToLower();
                if (product == "cheese")
                {
                    totalCalories += 500;
                }
                else if (product == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if (product == "salami")
                {
                    totalCalories += 600;
                }
                else if (product == "pepper")
                {
                    totalCalories += 50;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
