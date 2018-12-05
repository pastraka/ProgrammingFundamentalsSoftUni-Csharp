using System;
using System.Collections.Generic;

namespace citiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //създавам два вложени речника и един лист. В единият речник ми е континента, в другият държавата и в листа градовете.

            Dictionary<string, Dictionary<string, List<string>>> continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string continent = line[0];
                string country = line[1];
                string city = line[2];

                //пълнене на речниците и листа

                if (continentsData.ContainsKey(continent) == false)
                {
                    Dictionary<string, List<string>> current = new Dictionary<string, List<string>>();
                    current.Add(country, new List<string>() { city });
                    continentsData.Add(continent, current);
                }
                else if (continentsData[continent].ContainsKey(country) == false)
                {
                    continentsData[continent].Add(country, new List<string>() { city });
                }
                else
                {
                    continentsData[continent][country].Add(city);
                }
            }
            //изписване на речниците с вложен foreach
            foreach (var pair in continentsData)
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (var country in pair.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
