using System;
using System.Linq;
using System.Collections.Generic;

namespace appendList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split('|')
                .Reverse()
                .Select(s => string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)))));

            //List<string> result = new List<string>();
            //input.Reverse();

            //for (int i = 0; i < input.Count; i++)
            //{
            //    string text = input[i];
            //    string[] splitted = text.Split(" .,!@#".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //    string merged = string.Join(" ", splitted);
            //    result.Add(merged);
            //}

            //Console.WriteLine(string.Join(" ", result));
        }
    }
}
