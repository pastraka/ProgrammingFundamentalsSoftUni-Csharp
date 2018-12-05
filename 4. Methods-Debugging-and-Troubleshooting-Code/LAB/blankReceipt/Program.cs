using System;

namespace blankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader('-', 30);
            PrintBody('_', 20);
            PrintFooter('-', 30);
        }

        static void PrintHeader(char symbol, int count1)
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string (symbol, count1));
        }

        static void PrintBody(char underScore, int count2)
        {
            Console.WriteLine("Charged to" + new string(underScore, count2));
            Console.WriteLine("Received by" + new string(underScore, count2 - 1));
        }

        static void PrintFooter(char symbol2, int count3)
        {
            Console.WriteLine(new string(symbol2, count3));
            Console.WriteLine('\u00A9' + " SoftUni");
        }
    }
}