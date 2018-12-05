using System;
using System.Collections.Generic;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> text = new Dictionary<string, int>();

            string[] input = Console.ReadLine().ToLower().Split();

       
            foreach (var item in input)
            {
                if (text.ContainsKey(item) == false)
                {
                    text.Add(item, 1);
                }
                else
                {
                    text[item]++;
                }
            }
            List<string> result = new List<string>();
            foreach (var item in text)
            {
               if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
