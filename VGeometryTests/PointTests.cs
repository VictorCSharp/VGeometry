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
    public class PointTests
    {
        [TestMethod()]
        public void SegmentDistanceTest()
        {
            Point P2 = new(1, 1);
            Point Q2 = new(2, 2);
            Segment s2 = new(P2, Q2);
            var N = new Point(1, 0);
            var d = N.Distance(s2);

            Assert.IsTrue(d - Math.Sqrt(2) / 2 < Math.Pow(10, -8));
        }

        [TestMethod()]
        public void ProjectionTest()
        {
            Point P2 = new(1, 1);
            Point Q2 = new(2, 2);
            Segment s2 = new(P2, Q2);
            var N = new Point(1, 0);

            Assert.IsTrue(N.Projection(s2) == new Point(0.5, 0.5));
        }
    }
}