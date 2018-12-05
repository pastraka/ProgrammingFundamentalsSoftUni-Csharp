using System;

namespace geometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figType = Console.ReadLine();
            double figParam = double.Parse(Console.ReadLine());
            double figArea = CalculateFigureArea(figParam, figType);
            Console.WriteLine($"{figArea:f2}");
        }

        static double CalculateFigureArea(double figParam, string figType)
        {
            double area = 0;
            if (figType == "triangle")
            {
                double height = double.Parse(Console.ReadLine());
                area = (figParam * height) / 2;
            }
            else if (figType == "square")
            {
                area = Math.Pow(figParam, 2);
            }
            else if (figType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                area = figParam * width;
            }
            else if (figType == "circle")
            {
                area = Math.PI * Math.Pow(figParam, 2);
            }
            return area;
        }
    }
}
