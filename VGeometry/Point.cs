using System;

namespace VGeometry
{
    public class Point
    {
        public double x;
        public double y;

        public static readonly Point Infinity = new Point(Double.NaN, Double.NaN);

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double distance(Point P)
        {
            return Math.Sqrt(Math.Pow(this.x - P.x, 2) + Math.Pow(this.y - P.y, 2));
        }

        override
        public string ToString()
        {
            return $"{this.x}, {this.y}";
        }

        public void print()
        {
            Console.WriteLine(this);
        }

        public static Point operator+ (Point X, Point Y)
        {
            return new Point(X.x + Y.x, X.y + Y.y);
        }
        public static Point operator- (Point X, Point Y)
        {
            return new Point(X.x - Y.x, X.y - Y.y);
        }

        public static Point operator *(double k, Point Y)
        {
            return new Point(k*Y.x, k*Y.y);
        }
        public static double distance (Point K, Point L)
        {
            return K.distance(L); 
        }



    }
}
