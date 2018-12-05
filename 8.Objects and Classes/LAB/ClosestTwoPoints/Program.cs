using System;
using System.Linq;

namespace closestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] AllPoints = GetThePoints(n);
            Point[] ClosestPoints = FindClosestPoints(AllPoints);
            double minDistance = ClosestPoints[0].CalcDistance(ClosestPoints[1]);

            Console.WriteLine("{0:f3}", minDistance);
            Console.WriteLine($"({ClosestPoints[0].X}, {ClosestPoints[0].Y})");
            Console.WriteLine($"({ClosestPoints[1].X}, {ClosestPoints[1].Y})");
        }

        static Point[] GetThePoints(int numberOfPoints)
        {
            Point[] AllPoints = new Point[numberOfPoints];
            for (int i = 0; i < numberOfPoints; i++)
            {
                double[] splitted = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToArray();
                Point currentPoint = new Point(splitted[0], splitted[1]);
                AllPoints[i] = currentPoint;
            }

            return AllPoints;
        }

        static Point[] FindClosestPoints(Point[] points)
        {
            Point[] ClosestPoints = new Point[2];
            ClosestPoints[0] = points[0];
            ClosestPoints[1] = points[1];
            double minDistance = points[0].CalcDistance(points[1]);
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (points[i].CalcDistance(points[j]) < minDistance)
                    {
                        minDistance = points[i].CalcDistance(points[j]);
                        ClosestPoints[0] = points[i];
                        ClosestPoints[1] = points[j];
                    }
                }

            }
            return ClosestPoints;
        }
    }

    class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public double CalcDistance(Point other)
        {
            double a = this.X - other.X;
            double b = this.Y - other.Y;
            double distance = Math.Sqrt(GetPow(a) + GetPow(b));
            return distance;
        }

        double GetPow(double number)
        {
            double power = Math.Pow(number, 2);
            return power;
        }
    }
}