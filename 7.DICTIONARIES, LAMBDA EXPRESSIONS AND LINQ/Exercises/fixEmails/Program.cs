using System;
using System.Collections.Generic;
using System.Linq;

namespace fixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                string end = email.Substring(email.Length - 2, 2).ToLower();
                if (end != "uk" && end != "us")
                {
                    data.Add(name, email);
                }
                name = Console.ReadLine();

            }
            foreach (KeyValuePair<string, string> names in data)
            {
                Console.WriteLine($"{names.Key} -> {names.Value}");
            }
        }
    }
}
