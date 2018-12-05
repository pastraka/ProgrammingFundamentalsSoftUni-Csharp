using System;

namespace numberInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string reversed = ReverseNumber(num);
            Console.WriteLine(reversed);
        }

        static string ReverseNumber(string num)
        {
            string reversed = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                reversed += num[i];
            }
            return reversed;
        }
    }
}
