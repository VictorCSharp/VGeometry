using System;

namespace VGeometry
{
    public class Polygon
    {
        private readonly int n;
        public Point[] vertices;

        public Polygon(Point[] v)
        {
            this.n = v.Length;
            this.vertices = v;
        }

        public double perimeter ()
        {
            double pr = 0d;
            for (int i = 0; i <= n-2; i++)
            {
                pr += this.vertices[i].distance(this.vertices[i + 1]);     
            }
           return pr + this.vertices[0].distance(this.vertices[n - 1]);
        }

        public void print ()
        {
            for (int i = 0; i < n; i++)
            {
                this.vertices[i].print();
            }
        }
        
        public double area()
        {
            // TODO: Add test case
            double area = 0;
            for (int i = 0; i <= this.n - 3; i++)
            {
                // 0, i + 1, i + 2;
                Triangle x = Triangle.init(this.vertices[0], this.vertices[i + 1], this.vertices[i + 2]);
                area += x.area();
            }

            return area;
        }

        public Point centroid()
        {
            Point r = new Point (0, 0);
            for (int i = 0; i < this.n; i++)
            {
                r = vertices[i] + r;
            }
            return (1d / n) * r;
        }

        /// <summary>
        /// Checks if the polygon is self-intersectig or simple
        /// </summary>
        /// <returns></returns>
        public bool isSimple()
        {
            bool simple = true;
            for (int i = 0; i <= this.n - 3; i++)
            {
                //the first edge
                Segment a = new Segment(this.vertices[i], this.vertices[i + 1]);
                for (int m = i + 2; m <= this.n-1; m++)
                {
                    //the last edge ends at 0, not at n!
                    int k = (m + 1 == n) ? 0 : m + 1;
                    
                    if (i == m || i == k || i+1 == m || i+1 == k) continue;
                    Segment b = new Segment(this.vertices[m], this.vertices[k]);
                    //Console.WriteLine($"{i}{i + 1} {m}{k}");

                    //We check if the two edges intersect
                    if (a.IntersectInInterior(b))
                    {
                        return false;
                    }
                }
            }
            return simple;
        }
    }
}
