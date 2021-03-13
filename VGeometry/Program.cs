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
            Point X = new Point(0, 0);
            Point Y = new Point(1, 0);
            Point Z = new Point(1, 1);
            Point V = new Point(0, 1);

            Segment s1 = new Segment(X, Z);

            Segment s2 = new Segment(Y, V);

            Point I = s1.Intersect(s2);
            I.print();

        }
    }
}
