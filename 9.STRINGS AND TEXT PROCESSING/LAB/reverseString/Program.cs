﻿using System;
using System.Text;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            //stringBuilder 
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
