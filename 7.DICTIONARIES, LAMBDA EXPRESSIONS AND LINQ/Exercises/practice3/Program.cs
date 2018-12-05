using System;
using System.Collections.Generic;

namespace practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceBook = new Dictionary<string, int>();


            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (resourceBook.ContainsKey(resource) == false)
                {
                    resourceBook.Add(resource, quantity);
                }
                else
                {
                    resourceBook[resource] += quantity; 
                }
            }

            foreach (KeyValuePair<string, int> kvp in resourceBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
