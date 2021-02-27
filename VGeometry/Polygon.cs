namespace VGeometry
{
    class Polygon
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
    }
}
