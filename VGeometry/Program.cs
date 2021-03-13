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
            Point Q = new Point(0.5, 2);
            Point V = new Point(0, 1);
           
            Point[] vert = new Point[] { X, Y, Z, Q,         V };
            
            Polygon p = new Polygon(vert);

            p.centroid().print();

            



        }
    }
}
