using System;
using System.Collections.Generic;

namespace aMinerTask
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
                    break;

                int quantity = int.Parse(Console.ReadLine());

                //if (resourceBook.ContainsKey(resource))
                //{
                //    resourceBook[resource] += quantity;
                //}
                //else
                //{
                //    resourceBook.Add(resource, quantity);
                //}
                if (resourceBook.ContainsKey(resource) == false)
                {
                    resourceBook.Add(resource, 0);
                }
                resourceBook[resource] += quantity;
            }
            foreach (KeyValuePair<string, int> resource in resourceBook)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
