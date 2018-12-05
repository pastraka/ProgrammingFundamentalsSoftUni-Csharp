using System;
using System.Drawing;
using System.Linq;

namespace distanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read both poitns separately
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            
            //Calculate The Distance Between them 
            double distance = CalcDistance(p1, p2);
            
            //Print the Distance
            Console.WriteLine($"Distance: {distance:f3}");
        }
        
        //
        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }
        
        //Calculate Distance Method
        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return (Math.Sqrt(deltaX * deltaX + deltaY * deltaY));
        }
    }
}
