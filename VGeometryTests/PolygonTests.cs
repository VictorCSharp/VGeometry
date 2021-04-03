using Microsoft.VisualStudio.TestTools.UnitTesting;
using VGeometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGeometry.Tests
{
    [TestClass()]
    public class PolygonTests
    {
        [TestMethod()]
        public void perimeterTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void printTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void areaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void centroidTest()
        {
            Point A = new Point(1, 1);
            Point B = new Point(2, 1);
            Point C = new Point(2, 2);
            Point D = new Point(1, 2);

            Polygon p = new Polygon(new Point[] { A, B, C, D });
            Point M = p.centroid();

            Assert.AreEqual(M.x, 1.5);
            Assert.AreEqual(M.y, 1.5);

        }

        [TestMethod()]
        public void isSimpleTrueTest()
        {
            Point A = new Point(1, 1);
            Point B = new Point(2, 1);
            Point C = new Point(2, 2);
            Point D = new Point(1, 2);
            Point E = new Point(0, 1.5);

            Polygon p = new Polygon(new Point[] { A, B, C, D, E });
            Assert.IsTrue(p.isSimple());
        }

        [TestMethod()]
        public void isSimpleFalseTest()
        {
            Point A = new Point(1, 1);
            Point B = new Point(2, 1);
            Point C = new Point(2, 2);
            Point D = new Point(1, 2);
            Point E = new Point(0, 1.5);

            Polygon p = new Polygon(new Point[] { A, B, C, E, D });
            Assert.IsFalse(p.isSimple());
        }
    }
}