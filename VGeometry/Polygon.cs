namespace VGeometry
{
    public class Polygon
    {
        int n;
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
    }
}
