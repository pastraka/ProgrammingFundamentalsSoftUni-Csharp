using System;
using System.Text.RegularExpressions;

namespace softuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

            double totalIncome = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(line, regex))
                {
                    Match match = Regex.Match(line, regex);
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double totalPrice = price * count;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
