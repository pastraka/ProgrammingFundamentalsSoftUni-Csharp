using System;

namespace longerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double line1 = CalculatePhytagorean(Math.Pow(x2 - x1, 2), Math.Pow(y2 - y1, 2));
            double line2 = CalculatePhytagorean(Math.Pow(x3 - x4, 2), Math.Pow(y3 - y4, 2));

            if (line1 >= line2)
            {
                PrintClosureLine(x1, y1, x2, y2);
            }
            else
            {
                PrintClosureLine(x3, y3, x4, y4);
            }
        }

        static void PrintClosureLine(double x1, double y1, double x2, double y2)
        {
            double line1 = CalculatePhytagorean(x1, y1);
            double line2 = CalculatePhytagorean(x2, y2);
            if (line1 <= line2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        static double CalculatePhytagorean(double x, double y)
        {
            double result = Math.Sqrt(x * x + y * y);
            return result;
        }
    }
}
