using System;

namespace centerPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosureLine(x1, y1, x2, y2);
        }

        static void PrintClosureLine(double x1, double y1, double x2, double y2)
        {
            double line1 = CalculatePhytagorean(x1, y1);
            double line2 = CalculatePhytagorean(x2, y2);
            if (line1 <= line2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double CalculatePhytagorean(double x, double y)
        {
            double result = Math.Sqrt(x * x + y * y);
            return result;
        }
    }
}
