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
        public void TriangleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void initTest()
        {
            Assert.Fail();
        }

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
           
            Point A = new Point(0, 0);
            Point B = new Point(2, 0);
            Point C = new Point(1, 5);
            Triangle t = Triangle.init(A, B, C);
            double k = Math.Cos(Math.Atan(5));
            double v = t.cosa();
            Assert.IsTrue(Math.Abs(k-v) < 1e-12);
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
    }
}