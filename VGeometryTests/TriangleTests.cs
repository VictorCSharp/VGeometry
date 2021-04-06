using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VGeometry.Tests
{
    [TestClass()]
    public class TriangleTests
    {
         [TestMethod()]
        public void AngleRadiansTest()
        {
            Point A = new(1, 1);
            Point B = new(2, 1);
            Point C = new(2, 2);

            Assert.AreEqual(Triangle.AngleRadians(A, B, C), Math.PI / 2);
        }
    }
}