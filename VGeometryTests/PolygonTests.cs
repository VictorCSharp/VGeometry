using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VGeometry.Tests
{
    [TestClass()]
    public class PolygonTests
    {
        [TestMethod()]
        public void CentroidTest()
        {
            Point A = new(1, 1);
            Point B = new(2, 1);
            Point C = new(2, 2);
            Point D = new(1, 2);

            Polygon p = new(new Point[] { A, B, C, D });
            Point M = p.Centroid();

            Assert.AreEqual(M.x, 1.5);
            Assert.AreEqual(M.y, 1.5);

        }

        [TestMethod()]
        public void IsSimpleTrueTest()
        {
            Point A = new(1, 1);
            Point B = new(2, 1);
            Point C = new(2, 2);
            Point D = new(1, 2);
            Point E = new(0, 1.5);

            Polygon p = new(new Point[] { A, B, C, D, E });
            Assert.IsTrue(p.IsSimple());
        }

        [TestMethod()]
        public void IsSimpleFalseTest()
        {
            Point A = new(1, 1);
            Point B = new(2, 1);
            Point C = new(2, 2);
            Point D = new(1, 2);
            Point E = new(0, 1.5);

            Polygon p = new(new Point[] { A, B, C, E, D });
            Assert.IsFalse(p.IsSimple());
        }
    }
}