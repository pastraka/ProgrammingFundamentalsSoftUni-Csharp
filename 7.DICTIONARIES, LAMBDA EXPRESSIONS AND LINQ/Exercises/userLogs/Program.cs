using System;
using System.Collections.Generic;

namespace userLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> addrres = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string userName = tokens[tokens.Length - 1];
                string ipAddrres = tokens[1];

                if (addrres.ContainsKey(userName) == false)
                {
                    addrres.Add(userName, new Dictionary<string, int>());
                }
                if (addrres[userName].ContainsKey(ipAddrres) == false)
                {
                    addrres[userName].Add(ipAddrres, 0);
                }
                addrres[userName][ipAddrres]++;
            }
            foreach (var user in addrres)
            {
                Console.WriteLine($"{user.Key}:");

                List<string> ipNumber = new List<string>();

                foreach (var ip in user.Value)
                {
                    ipNumber.Add($"{ip.Key} => {ip.Value}");
                }
                Console.Write(string.Join(", ", ipNumber));
                Console.WriteLine(".");
            }
        }
    }
}
