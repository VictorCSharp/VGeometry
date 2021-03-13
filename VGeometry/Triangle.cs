using System;

namespace VGeometry
{
    public class Triangle:Polygon
    {
        public Point A;
        public Point B;
        public Point C;
        private double a;
        private double b;
        private double c;

        public Triangle(Point[] v): base(v) //syntax!
        {
            this.A = v[0];
            this.B = v[1];
            this.C = v[2];
            this.a = B.distance(C);
            this.b = A.distance(C);
            this.c = A.distance(B);
        }
        public static Triangle init(Point A, Point B, Point C)
        {
            Point[] v = new Point[3] { A, B, C };
            return new Triangle(v);
        }

        public double geta()
        {
            return this.a;
        }

        public double cosc()
        {
            return (Math.Pow(this.a, 2) + Math.Pow(this.b, 2) - Math.Pow(this.c, 2)) /( 2 * a * b);       
        }
        public double cosa()
        {
            return (Math.Pow(this.c, 2) + Math.Pow(this.b, 2) - Math.Pow(this.a, 2)) / (2 * c * b);
        }
        public double cosb()
        {
            return (Math.Pow(this.c, 2) + Math.Pow(this.a, 2) - Math.Pow(this.b, 2)) / (2 * c * a);
        }
        /// <summary>
        /// Returns the area of the triangle
        /// </summary>
        /// <returns>double</returns>
        new public double area()
        {
            double p = this.perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
