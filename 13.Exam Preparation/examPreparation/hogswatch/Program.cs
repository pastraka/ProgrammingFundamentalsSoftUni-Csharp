using System;

namespace hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homes = int.Parse(Console.ReadLine());
            int initialPresents = int.Parse(Console.ReadLine());
            int presents = initialPresents;
            int homeCommings = 0;
            int additionalPresents = 0;

            for (int i = 1; i <= homes; i++)
            {
                int children = int.Parse(Console.ReadLine());

                if (presents >= children)
                {
                    presents -= children;
                    continue;
                }

                int presentsShort = children - presents;
                homeCommings++;

                int presentsToGet = initialPresents / (i) * (homes - i) + presentsShort;
                additionalPresents += presentsToGet;
                presents += presentsToGet - children;
            }

            if (homeCommings == 0)
            {
                Console.WriteLine(presents);
            }
            else
            {
                Console.WriteLine(homeCommings);
                Console.WriteLine(additionalPresents);
            }
        }
    }
}
