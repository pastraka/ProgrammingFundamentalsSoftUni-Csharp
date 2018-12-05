using System;
using System.Collections.Generic;
using System.Linq;

namespace populationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary - country cities
            //Dictionary - total population
            //Read input
            //Fill dictionaries
            //sort countries
            //country sort cities
            //print

            Dictionary<string, long> totalPopulation = new Dictionary<string, long>();

            Dictionary<string, Dictionary<string, long>> countriesAndCities = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "report")
                {
                    break;
                }

                string[] tokens = line.Split('|');
                string city = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);

                if (totalPopulation.ContainsKey(country) == false)
                {
                    totalPopulation.Add(country, 0);
                    countriesAndCities.Add(country, new Dictionary<string, long>());
                }
                totalPopulation[country] += population;

                countriesAndCities[country].Add(city, population);
            }
            foreach ( var country in totalPopulation.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                Dictionary<string, long> cities = countriesAndCities[country.Key]
                .OrderByDescending(c => c.Value)//sorting every city -> population
                .ToDictionary(x => x.Key, x => x.Value);

                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
