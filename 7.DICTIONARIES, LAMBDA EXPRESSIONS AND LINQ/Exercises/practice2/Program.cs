﻿using System;
using System.Collections.Generic;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();
                if(line == "END")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "A":
                        string name = tokens[1];
                        string phone = tokens[2];

                        if (phoneBook.ContainsKey(name))
                        {
                            phoneBook[name] = phone;
                        }
                        else
                        {
                            phoneBook.Add(name, phone);
                        }
                        break;
                    case "S":
                        string searchName = tokens[1];
                        if (phoneBook.ContainsKey(searchName))
                        {
                            string foundNumber = phoneBook[searchName];
                            Console.WriteLine($"{searchName} -> {foundNumber}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {searchName} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (KeyValuePair<string, string> contact in phoneBook)
                        {
                            Console.WriteLine($"{contact.Key} -> {contact.Value}");
                        }
                        break;
                }
            }
        }
    }
}
