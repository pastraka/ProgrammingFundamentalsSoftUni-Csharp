using System;
using System.Linq;

namespace distanceBetweenPoints2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            double distance = Point.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:f3}");
        }

        private static Point ReadPoint()
        {
            int[] pointCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return new Point(pointCoord[0], pointCoord[1]);
        }
    }

    class Point
    {
        //properties //fields

        public int X { get; set; }
        public int Y { get; set; }

        //constructor

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
}
