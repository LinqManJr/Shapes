using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape.Core;
using Shapes;

namespace Shape.Test
{
    [TestClass]
    public class ShapeTest
    {

        #region Circle

        [TestMethod]
        public void ShouldCalculateCircleSquare()
        {
            double expectedSquare = 12.566370614359;
            var circle = new Circle(2);
            Assert.AreEqual(expectedSquare, circle.GetSquare(), 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Radius value must be more than -1")]
        public void ShouldThrowExceptionIfRadiusNegative()
        {            
            var circle = new Circle(-1);
            var result = circle.GetSquare();
        }

        #endregion

        #region Triangle

        [TestMethod]
        public void ShouldCalculateTriangleSquare()
        {
            double expectedSquare = 1.73205;
            var triangle = new Triangle(2,2,2);
            Assert.AreEqual(expectedSquare, triangle.GetSquare(), 0.1);
        }

        [TestMethod]
        public void ShouldReturnTrueIfTriangleIsRight()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void ShouldReturnFalseIfTriangleIsNotRight()
        {
            var triangle = new Triangle(3, 4, 8);
            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [DataTestMethod]
        [DataRow(0, 1, 3)]
        [DataRow(2, -1, 4)]
        [DataRow(3, 4, -2)]
        [ExpectedException(typeof(Exception), "Side must be a positive value")]
        public void ShouldThrowExceptionIfTriangleHaveNegativeSide(int a,int b,int c)
        {
            var triangle = new Triangle(a, b, c);
            var result = triangle.GetSquare();
        }

        #endregion
    }
}
