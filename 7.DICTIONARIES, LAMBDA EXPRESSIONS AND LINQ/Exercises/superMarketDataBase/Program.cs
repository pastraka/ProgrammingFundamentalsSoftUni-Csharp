using System;
using System.Collections.Generic;

namespace superMarketDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productQuantity = new Dictionary<string, int>();
            Dictionary<string, double> productPrice = new Dictionary<string, double>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stocked")
                {
                    break;
                }
                string[] tokens = line.Split();
                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (productQuantity.ContainsKey(name) == false)
                {
                    productQuantity[name] = 0;
                    productPrice[name] = price;
                }
                productQuantity[name] += quantity;
                productPrice[name] = price;
            }
            double grandTotal = 0;
            foreach (var productName in productPrice)
            {
                foreach (var productQ in productQuantity)
                {
                    if (productQ.Key == productName.Key)
                    {
                        double total = productName.Value * productQ.Value;
                        grandTotal += total;

                        Console.WriteLine($"{productName.Key}: ${productName.Value:f2} * {productQ.Value} = ${total:f2}");
                    }
                }
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
