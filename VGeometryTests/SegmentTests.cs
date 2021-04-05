using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VGeometry.Tests
{
    [TestClass()]
    public class SegmentTests
    {

        [TestMethod()]
        public void LengthTest()
        {
            Point P = new(0, 0);
            Point Q = new(1, 1);
            Segment s = new(P, Q);

            Assert.IsTrue(s.Length().Equals(Math.Sqrt(2)));
        }

        [TestMethod()]
        public void ContainsTest()
        {
            Point P = new(0, 0);
            Point Q = new(1, 1);
            Segment s = new(P, Q);
            Point M = new(0.5, 0.5);

            Assert.IsTrue(s.Contains(M));
        }

        [TestMethod()]
        public void NotContainsTest()
        {
            Point P = new(0, 0);
            Point Q = new(1, 1);
            Segment s = new(P, Q);
            Point M = new(1.5, 0.5);

            Assert.IsFalse(s.Contains(M));
        }

        [TestMethod()]
        public void IntersectTest()
        {
            Point P1 = new(0, 0);
            Point Q1 = new(1, 1);
            Segment s1 = new(P1, Q1);

            Point P2 = new(0, 1);
            Point Q2 = new(1, 0);
            Segment s2 = new(P2, Q2);

            Point X = s1.Intersect(s2);

            Assert.IsTrue(X.x.Equals(0.5) && X.y.Equals(0.5));
        }

        [TestMethod()]
        public void IntersectInInteriorTrueTest()
        {
            Point P1 = new(0, 0);
            Point Q1 = new(5, 0);
            Segment s1 = new(P1, Q1);

            Point P2 = new(1, 1);
            Point Q2 = new(2, -2);
            Segment s2 = new(P2, Q2);

            Assert.IsTrue(s1.IntersectInInterior(s2), s1.Intersect(s2).ToString());
        }

        [TestMethod()]
        public void IntersectInInteriorFalseTest()
        {
            Point P1 = new(0, 0);
            Point Q1 = new(0, 5);
            Segment s1 = new(P1, Q1);

            Point P2 = new(1, 1);
            Point Q2 = new(2, -2);
            Segment s2 = new(P2, Q2);

            Assert.IsFalse(s1.IntersectInInterior(s2), s1.Intersect(s2).ToString());
        }
    }
}