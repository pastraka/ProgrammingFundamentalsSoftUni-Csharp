using System;
using System.Linq;

namespace rectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstCoord = ReadRectangle();
            Rectangle secondCoord = ReadRectangle();

            Console.WriteLine(firstCoord.IsInside(secondCoord) ? "Inside" : "Not Inside");
        }

        public static Rectangle ReadRectangle()
        {
            int[] pointCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Rectangle(pointCoord[0], pointCoord[1], pointCoord[2], pointCoord[3]);
        }
    }

    class Rectangle
    {
        //properties
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //property

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        //property

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        //constructor

        public Rectangle(int Left, int Top, int Width, int Height)
        {
            this.Left = Left;
            this.Top = Top;
            this.Width = Width;
            this.Height = Height;
        }

        int CalcArea()
        {
            return Width * Height;
        }

        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}
