using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGeometry
{
    class Segment
    {
        Point K;
        Point L;
        public Segment (Point K, Point L)
        {
            this.K = K;
            this.L = L;

        }
       public double Length ()
        {
          return  Point.distance(K, L);
        }
            
    }
}
