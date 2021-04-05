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
    public class TriangleTests
    {
        [TestMethod()]
        public void GetATest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CosCTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CosATest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CosBTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AreaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AngleRadiansTest()
        {
            Point A = new Point(1, 1);
            Point B = new Point(2, 1);
            Point C = new Point(2, 2);

            Assert.AreEqual(Triangle.AngleRadians(A, B, C), Math.PI/2);
        }
    }
}