using System;
using System.Collections.Generic;

namespace practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userEmail = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();
                string end = email.Substring(email.Length - 2, 2).ToLower();
                if (end != "uk" && end != "us")
                {
                    userEmail.Add(name, email);
                }
            }

            foreach (var item in userEmail)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
