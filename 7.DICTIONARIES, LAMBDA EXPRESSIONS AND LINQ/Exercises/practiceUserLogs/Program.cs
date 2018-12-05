using System;
using System.Collections.Generic;

namespace practiceUserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> address = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                //ip= ip address message = message name = name
                string[] tokens = input.Split("= ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string ipAddress = tokens[1];
                string userName = tokens[tokens.Length - 1];

                if (address.ContainsKey(userName) == false)
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(ipAddress, 0);
                    address.Add(userName, current);
                }
                 if (address[userName].ContainsKey(ipAddress) == false)
                {
                    address[userName].Add(ipAddress, 0);
                }
                address[userName][ipAddress]++;
            }
            foreach (var user in address)
            {
                Console.WriteLine($"{user.Key}:");
                List<string> ipNumber = new List<string>();

                foreach (var item in user.Value)
                {
                    ipNumber.Add($"{item.Key} => {item.Value}");
                }
                Console.Write(string.Join(", ", ipNumber));
                Console.WriteLine(".");
            }
        }
    }
}
