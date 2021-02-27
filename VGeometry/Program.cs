using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Point Z = new Point(1, 1);
            Point X = new Point(0, 0);
            Point Y = new Point(0, 1);
            Triangle Tr = new Triangle(X, Y, Z);

            Point[] b = new Point[4];
            b[0] = X;
            b[1] = Y;
            b[2] = Z;
            b[3] = new Point(1, 0);

            Polygon P = new Polygon(b);

            Console.WriteLine(Tr.area());

        }
    }
}
