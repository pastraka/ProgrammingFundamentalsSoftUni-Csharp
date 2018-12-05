using System;
using System.Text;

namespace unicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            StringBuilder uni = new StringBuilder();

            foreach (char c in n)
            {
                uni.Append("\\u");
                uni.Append(String.Format("{0:x4}", (int)c));
            }

            Console.WriteLine(uni.ToString());
        }
    }
}
