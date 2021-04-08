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
        public double Distance(Point P)
        {
            return Math.Sqrt(Math.Pow(this.x - P.x, 2) + Math.Pow(this.y - P.y, 2));
        }

        /// <summary>
        /// Calculates the distance between point and line
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public double Distance(Segment s)
        {
            var (a, b, c) = s.LineEq();
            return Math.Abs(a * this.x + b * this.y + c) / Math.Sqrt(a * a + b * b);
        }

        override
        public string ToString()
        {
            return $"{this.x}, {this.y}";
        }

        public void Print()
        {
            Console.WriteLine(this);
        }

        public static Point operator +(Point X, Point Y)
        {
            return new Point(X.x + Y.x, X.y + Y.y);
        }
        public static Point operator -(Point X, Point Y)
        {
            return new Point(X.x - Y.x, X.y - Y.y);
        }

        public static Point operator *(double k, Point Y)
        {
            return new Point(k * Y.x, k * Y.y);
        }

        public static bool operator ==(Point A, Point B)
        {
            double tolerance = Math.Pow(10, -8);
            return Math.Abs(A.x - B.x) < tolerance && Math.Abs(A.y - B.y) < tolerance;
        }

        public static bool operator !=(Point A, Point B)
        {
            double tolerance = Math.Pow(10, -8);
            return Math.Abs(A.x - B.x) >= tolerance || Math.Abs(A.y - B.y) >= tolerance;
        }

        public static double Distance(Point K, Point L)
        {
            return K.Distance(L);
        }

        /// <summary>
        /// Returns the Point of projection of this point
        /// upon the segment.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Point Projection(Segment s)
        {
            var (a, b, c) = s.LineEq();
            double denom = a * a + b * b;
            double xx = b * (b * this.x - a * this.y) - a * c;
            double yy = a * (-b * this.x + a * this.y) - b * c;
            return new(xx/denom, yy/denom);
        }
    }
}
