using System;

namespace VGeometry
{
    class Triangle
    {
        public Point A;
        public Point B;
        public Point C;
        private double a;
        private double b;
        private double c;
        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.a = B.distance(C);
            this.b = A.distance(C);
            this.c = A.distance(B);
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

        public double area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
