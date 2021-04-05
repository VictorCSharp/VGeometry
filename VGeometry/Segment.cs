using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGeometry
{
    public class Segment
    {
        public Point P1;
        public Point P2;
        public Segment(Point P1, Point P2)
        {
            this.P1 = P1;
            this.P2 = P2;
        }

       public double Length ()
       {
            return Point.Distance(P1, P2);
       }
        /// <summary>
        /// Check if the Segment conatins the Point
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool Contains(Point p)
        {
            double x = p.x, y = p.y;

            return 
                (
                    (x >= P1.x && x <= P2.x) || (x >= P2.x && x <= P1.x)
                )
            &&
                (   
                    (y >= P1.y && y <= P2.y) || (y >= P2.y && y <= P1.y)
                );
        }

        /// <summary>
        /// Checks if two lines intersect and returns the Point of intersection.
        /// If parallel retur Infinity
        /// </summary>
        /// <param name="s"></param>
        /// <param name="tolerance">Difference tollerance</param>
        /// <returns>Point</returns>
       public Point Intersect(Segment s, double tolerance = 0.000001)
       {
            double x1 = P1.x, y1 = P1.y;
            double x2 = P2.x, y2 = P2.y;

            double x3 = s.P1.x, y3 = s.P1.y;
            double x4 = s.P2.x, y4 = s.P2.y;

            // equations of the form x = c (two vertical lines)
            if (Math.Abs(x1 - x2) < tolerance && Math.Abs(x3 - x4) < tolerance && Math.Abs(x1 - x3) < tolerance)
            {
                throw new Exception("Both lines overlap vertically, ambiguous intersection points.");
            }

            //equations of the form y=c (two horizontal lines)
            if (Math.Abs(y1 - y2) < tolerance && Math.Abs(y3 - y4) < tolerance && Math.Abs(y1 - y3) < tolerance)
            {
                throw new Exception("Both lines overlap horizontally, ambiguous intersection points.");
            }

            //equations of the form x=c (two vertical lines)
            if (Math.Abs(x1 - x2) < tolerance && Math.Abs(x3 - x4) < tolerance)
            {
                return Point.Infinity;
            }

            //equations of the form y=c (two horizontal lines)
            if (Math.Abs(y1 - y2) < tolerance && Math.Abs(y3 - y4) < tolerance)
            {
                return Point.Infinity;
            }

            double x, y;

            //lineA is vertical x1 = x2 - slope will be infinity
            if (Math.Abs(x1 - x2) < tolerance)
            {
                //compute slope of line 2 (m2) and c2
                double m2 = (y4 - y3) / (x4 - x3);
                double c2 = -m2 * x3 + y3;

                //equation of vertical line is x = c
                x = x1;
                y = c2 + m2 * x1;
            }
            //lineB is vertical x3 = x4 - slope will be infinity
            else if (Math.Abs(x3 - x4) < tolerance)
            {
                //compute slope of line 1 (m1) and c2
                double m1 = (y2 - y1) / (x2 - x1);
                double c1 = -m1 * x1 + y1;

                x = x3;
                y = c1 + m1 * x3;
            }
            //lineA & lineB are not vertical 
            //(could be horizontal we can handle it with slope = 0)
            else
            {
                //compute slope of line 1 (m1) and c2
                double m1 = (y2 - y1) / (x2 - x1);
                double c1 = -m1 * x1 + y1;

                //compute slope of line 2 (m2) and c2
                double m2 = (y4 - y3) / (x4 - x3);
                double c2 = -m2 * x3 + y3;

                //solving equations
                x = (c1 - c2) / (m2 - m1);
                y = c2 + m2 * x;

                //verify by plugging intersection point (x, y)
                //in orginal equations to see if they intersect
                //otherwise x,y values will not be finite and will fail this check
                if (!(Math.Abs(-m1 * x + y - c1) < tolerance
                    && Math.Abs(-m2 * x + y - c2) < tolerance))
                {
                    return new Point(Double.NaN, Double.NaN);
                }
            }

            return new Point(x, y);
        }

       public bool IntersectInInterior(Segment s, double tolerance = 0.000001)
        {
            Point I = this.Intersect(s, tolerance);

            return this.Contains(I) && s.Contains(I);
        }
    }
}
