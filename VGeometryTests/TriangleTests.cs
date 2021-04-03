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
        public void getaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void coscTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void cosaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void cosbTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void areaTest()
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