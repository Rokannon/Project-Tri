using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.mindbox;

namespace Unit_Tests
{
    [TestClass]
    public class GeomUtilsTest
    {
        [TestMethod]
        public void GeomUtils_CalculateRightTriangleArea_Regular()
        {
            Assert.AreEqual(6.0, GeomUtils.CalculateRightTriangleArea(3, 4, 5));
            Assert.AreEqual(30.0, GeomUtils.CalculateRightTriangleArea(5, 12, 13));
            Assert.AreEqual(60.0, GeomUtils.CalculateRightTriangleArea(8, 15, 17));
            Assert.AreEqual(84.0, GeomUtils.CalculateRightTriangleArea(7, 24, 25));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GeomUtils_CalculateRightTriangleArea_InvalidLength1()
        {
            try
            {
                GeomUtils.CalculateRightTriangleArea(-1, 1, 1);
            }
            catch (Exception exception)
            {
                throw new Exception(string.Empty, exception);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GeomUtils_CalculateRightTriangleArea_InvalidLength2()
        {
            try
            {
                GeomUtils.CalculateRightTriangleArea(1, -1, 1);
            }
            catch (Exception exception)
            {
                throw new Exception(string.Empty, exception);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GeomUtils_CalculateRightTriangleArea_InvalidLength3()
        {
            try
            {
                GeomUtils.CalculateRightTriangleArea(1, 1, -1);
            }
            catch (Exception exception)
            {
                throw new Exception(string.Empty, exception);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GeomUtils_CalculateRightTriangleArea_InvalidLength4()
        {
            try
            {
                GeomUtils.CalculateRightTriangleArea(0, 0, 0);
            }
            catch (Exception exception)
            {
                throw new Exception(string.Empty, exception);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GeomUtils_CalculateRightTriangleArea_NonRightTriangle()
        {
            try
            {
                GeomUtils.CalculateRightTriangleArea(1, 2, 3);
            }
            catch (Exception exception)
            {
                throw new Exception(string.Empty, exception);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GeomUtils_CalculateRightTriangleArea_Overflow()
        {
            try
            {
                GeomUtils.CalculateRightTriangleArea(3e160, 4e160, 5e160);
            }
            catch (Exception exception)
            {
                throw new Exception(string.Empty, exception);
            }
        }
    }
}
