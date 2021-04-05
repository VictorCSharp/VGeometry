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
            PolySimpleTest();
        }

        public static void PolySimpleTest()
        {
            Point[] v = new Point[6];
            Polygon p = new Polygon(v);
            p.IsSimple();
        }

        public static void TestConvexHull()
        {
            Point X = new Point(0, 0);
            Point Y = new Point(1, 0);
            Point Z = new Point(1, 1);
            Point V = new Point(0, 1);

            List<Point> t = new List<Point> { X, Y, Z, V, new Point(0.5, 0.3) };
            List<Point> hull = ConvexHull.GetConvexHull(t);
            hull.ForEach(p => p.Print());

            Console.WriteLine("=============");

            List<Point> t2 = new List<Point> { X, Y, Z, V, new Point(2.5, 0.3) };
            List<Point> hull2 = ConvexHull.GetConvexHull(t2);
            hull2.ForEach(p => p.Print());

            Console.WriteLine("=============");

            List<Point> t3 = new List<Point> { X, Y, Z, V, new Point(2.5, 2.3) };
            List<Point> hull3 = ConvexHull.GetConvexHull(t3);
            hull3.ForEach(p => p.Print());
        }
    }
}
