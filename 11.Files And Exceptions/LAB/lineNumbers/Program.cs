using System;
using System.IO;
using System.Linq;

namespace lineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines(@"..\..\..\input.txt");

            //for (int i = 0; i < text.Length; i++)
            //{
            //    File.AppendAllText(@"..\..\..\output.txt",
            //        $"{i + 1}. {text[i]}\n"
            //        );
            //}

            File.AppendAllLines(@"..\..\..\output.txt", text.Select((el, i) => $"{i + 1}. {el}"));
        }
    }
}
