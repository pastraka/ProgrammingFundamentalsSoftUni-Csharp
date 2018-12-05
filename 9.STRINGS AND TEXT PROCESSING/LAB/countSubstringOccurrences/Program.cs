using System;
using System.Linq;

namespace countSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine(); //"ababa caba";
            //string pattern = "aba";
            //int count = 0;

            //for (int i = 0; i <= input.Length - pattern.Length; i++)
            //{
            //    char[] subString = input
            //        .Skip(i) // skip index 0 на първата итерация
            //        .Take(pattern.Length) // взима 3 // aba
            //        .ToArray(); // прави го на string

            //    string toCheck = new string(subString);

            //    bool isEqual = String.Equals(pattern, toCheck);

            //    if (isEqual)
            //    {
            //        count++;
            //    }
            //}

            string input = Console.ReadLine().ToLower(); //"ababa caba";
            string pattern = Console.ReadLine().ToLower();
            int count = 0;

            int index = input.IndexOf(pattern);

            while (index != -1)
            {
                count++;
                index = input.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
