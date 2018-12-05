using System;
using System.Collections.Generic;
using System.Linq;

namespace distanceBetweenPoints2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                Point point = ReadPoint();
                points.Add(point);
            }

            double minDistance = double.MaxValue;
            Point[] pointsCoord = new Point[2];

            for (int p1 = 0; p1 < points.Count; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Count; p2++)
                {
                    Point firstPoint = points[p1];
                    Point secondPoint = points[p2];
                    double currentDistance = Point.CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        pointsCoord[0] = firstPoint;
                        pointsCoord[1] = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({pointsCoord[0].X}, {pointsCoord[0].Y})");
            Console.WriteLine($"({pointsCoord[1].X}, {pointsCoord[1].Y})");
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
