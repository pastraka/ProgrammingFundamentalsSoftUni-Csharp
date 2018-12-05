using System;

namespace restaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double smallHall = 2500;
            double terraceHall = 5000;
            double greatHall = 7500;
            double discount = 0.0;
            double packagePrice = 0.0;
            double pricePerPerson = 0.0;
            double totalPrice = 0.0;

            if (group <= 50)
            {
                if (package == "Normal")
                {
                    packagePrice = 500;
                    discount = 0.05;
                    pricePerPerson = smallHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                } else if (package == "Gold")
                {
                    packagePrice = 750;
                    discount = 0.10;
                    pricePerPerson = smallHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                } else if (package == "Platinum")
                {
                    packagePrice = 1000;
                    discount = 0.15;
                    pricePerPerson = smallHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                }
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {totalPrice:f2}$");

            } else if (group <= 100)
            {
                if (package == "Normal")
                {
                    packagePrice = 500;
                    discount = 0.05;
                    pricePerPerson = terraceHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                }
                else if (package == "Gold")
                {
                    packagePrice = 750;
                    discount = 0.10;
                    pricePerPerson = terraceHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                }
                else if (package == "Platinum")
                {
                    packagePrice = 1000;
                    discount = 0.15;
                    pricePerPerson = terraceHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                }
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {totalPrice:f2}$");

            } else if (group <= 120)
            {
                if (package == "Normal")
                {
                    packagePrice = 500;
                    discount = 0.05;
                    pricePerPerson = greatHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                }
                else if (package == "Gold")
                {
                    packagePrice = 750;
                    discount = 0.10;
                    pricePerPerson = greatHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                }
                else if (package == "Platinum")
                {
                    packagePrice = 1000;
                    discount = 0.15;
                    pricePerPerson = greatHall + packagePrice;
                    totalPrice = (pricePerPerson - (pricePerPerson * discount)) / group;
                }
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {totalPrice:f2}$");
            } else if (group > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
