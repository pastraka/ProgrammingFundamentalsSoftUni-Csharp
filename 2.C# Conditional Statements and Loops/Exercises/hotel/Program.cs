using System;

namespace hotel
{
    class Program
    { // May, June, July, August, September, October or December
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            int studio = 0;
            int twoBedRoom = 0;
            int suit = 0;
            double discount = 0;
            double totalStudio = 0;
            double totalTwoBed = 0;
            double totalSuit = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                twoBedRoom = 65;
                suit = 75;
                if (nights > 7)
                {
                    discount = 0.05;
                }
                if (month == "October" && nights > 7)
                {
                    totalStudio = (studio * nights) - studio;
                    totalStudio = totalStudio - (totalStudio * discount);
                }
                else
                {
                    totalStudio = studio * nights;
                    totalStudio = totalStudio - (totalStudio * discount);
                }
                totalTwoBed = twoBedRoom * nights;
                totalSuit = suit * nights;

            } else if (month == "June" || month == "September")
            {
                studio = 60;
                twoBedRoom = 72;
                suit = 82;
                discount = 0.10;
                
                if ( nights > 14)
                {
                    totalTwoBed = twoBedRoom * nights;
                    totalTwoBed = totalTwoBed - (totalTwoBed * discount);
                } else
                {
                    totalTwoBed = twoBedRoom * nights;
                }
                if (month == "September" && nights > 7)
                {
                    totalStudio = (studio * nights) - studio;
                }
                else
                {
                    totalStudio = studio * nights;
                }
                totalSuit = suit * nights;
                
            } else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                twoBedRoom = 77;
                suit = 89;
                if (nights > 14)
                {
                    discount = 0.15;
                }
                totalStudio = studio * nights;
                totalTwoBed = twoBedRoom * nights;
                totalSuit = suit * nights;
                totalSuit = totalSuit - (totalSuit * discount);
            }
            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
            Console.WriteLine($"Double: {totalTwoBed:f2} lv.");
            Console.WriteLine($"Suite: {totalSuit:f2} lv.");
        }
    }
}
