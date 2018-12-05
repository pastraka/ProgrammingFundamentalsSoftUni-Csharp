using System;

namespace calculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = PrintArea(widht, height);
            Console.WriteLine(area);
        }

        static double PrintArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
