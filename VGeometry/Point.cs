using System;

namespace VGeometry
{
    class Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double distance(Point P)
        {
            return Math.Sqrt(Math.Pow(this.x - P.x, 2) + Math.Pow(this.y - P.y, 2));
        }
        public void print()
        {
            Console.WriteLine($"{this.x}, {this.y}");
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

    }
}
