using System;
using System.Collections.Generic;
using System.Linq;

namespace practicePopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countriesAndCities = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "report")
                    break;

                string[] tokens = line.Split("|");
                string country = tokens[1];
                string city = tokens[0];
                long population = long.Parse(tokens[2]);

                if (countriesAndCities.ContainsKey(country) == false)
                {
                    countriesAndCities.Add(country, new Dictionary<string, long>());
                }
                if (countriesAndCities[country].ContainsKey(city) == false)
                {
                    countriesAndCities[country].Add(city, population);
                }
            }
            foreach (var country in countriesAndCities.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
