using System;

namespace rageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double rageExpenses = 0.0;
            int headsetCounter = 0;
            int mouseCounter = 0;
            int keyboardCounter = 0;
            int displayCounter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCounter++;
                }
                if (i % 3 == 0)
                {
                    mouseCounter++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCounter++;

                    if (keyboardCounter % 2 == 0)
                    {
                        displayCounter++;
                    }
                }
            }

            rageExpenses = (headsetCounter * headsetPrice) + (mouseCounter * mousePrice) + (keyboardCounter * keyboardPrice) + (displayCounter * displayPrice);

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
