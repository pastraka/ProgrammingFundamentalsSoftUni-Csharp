using System;
using System.IO;

namespace oddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines(@"..\..\..\input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    File.AppendAllText(@"..\..\..\output.txt", text[i] + "\n");
                }
            }
        }
    }
}
