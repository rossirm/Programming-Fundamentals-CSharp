using System;
using System.Linq;

namespace p03_Circles_Intersection
{
    class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            int d = Point.CalculateDistanceBetweenTwoPoints(c1.Center, c2.Center);
            if (d <= c1.Radius + c2.Radius)
            {
                return true;
            }
            return false;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static int CalculateDistanceBetweenTwoPoints(Point p1, Point p2)
        {
            return (int)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleCoord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondCircleCoord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            Point firstPoint = new Point(firstCircleCoord[0], firstCircleCoord[1]);
            Point secondPoint = new Point(secondCircleCoord[0], secondCircleCoord[1]);

            Circle firstCircle = new Circle(firstPoint, firstCircleCoord[2]);
            Circle secondCircle = new Circle(secondPoint, secondCircleCoord[2]);

            Console.WriteLine(Circle.Intersect(firstCircle, secondCircle) ? "Yes" : "No");
            /*
            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            */
        }
    }
}
