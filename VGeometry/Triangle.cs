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
            this.a = B.Distance(C);
            this.b = A.Distance(C);
            this.c = A.Distance(B);
        }
        public static Triangle Init(Point A, Point B, Point C)
        {
            Point[] v = new Point[3] { A, B, C };
            return new Triangle(v);
        }

        public double GetA()
        {
            return this.a;
        }

        public double GetB()
        {
            return this.b;
        }

        public double GetC()
        {
            return this.c;
        }

        public double CosC()
        {
            return (Math.Pow(this.a, 2) + Math.Pow(this.b, 2) - Math.Pow(this.c, 2)) /( 2 * a * b);       
        }
        public double CosA()
        {
            return (Math.Pow(this.c, 2) + Math.Pow(this.b, 2) - Math.Pow(this.a, 2)) / (2 * c * b);
        }
        public double CosB()
        {
            return (Math.Pow(this.c, 2) + Math.Pow(this.a, 2) - Math.Pow(this.b, 2)) / (2 * c * a);
        }
        /// <summary>
        /// Returns the area of the triangle
        /// </summary>
        /// <returns>double</returns>
        new public double Area()
        {
            double p = this.Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double AngleRadians(Point A, Point B, Point C)
        {
            // Translate, B to (0,0)
            double a = Math.Atan2(A.y - B.y, A.x - B.x);
            double c = Math.Atan2(C.y - B.y, C.x - B.x);

            return a - c;
        }

    }
}
