using System;
using System.Collections.Generic;
using System.Linq;

namespace takeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMessage = Console.ReadLine();
            List<int> numberList = new List<int>();
            List<char> charList = new List<char>();

            foreach (var symbol in inputMessage)
            {
                if (char.IsDigit(symbol))
                {
                    int num = int.Parse(symbol.ToString());
                    numberList.Add(num);
                }
                else
                {
                    charList.Add(symbol);
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numberList[i]);
                }
                else
                {
                    skipList.Add(numberList[i]);
                }
            }
            string result = null;
            int total = 0;

            for (int i = 0; i < skipList.Count; i++)
            {
                int skipCount = skipList[i];
                int takeCount = takeList[i];

                result += new string(charList.Skip(total).Take(takeCount).ToArray());
                total += skipCount + takeCount;
            }
            Console.WriteLine(result);
        }
    }
}
