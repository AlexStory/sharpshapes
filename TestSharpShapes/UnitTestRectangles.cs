using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;


namespace TestSharpShapes {
  [TestClass]
  public class UnitTestRectangles {
    [TestMethod]
    public void TestRectangleConstructor() {
      var rectangle = new Rectangle(40, 50);

      Assert.AreEqual(40, rectangle.Width);
      Assert.AreEqual(50, rectangle.Height);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestRectangleConstructorSanityChecksWidth() {
      var rectangle = new Rectangle(0, 50);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestRectangleConstructorSanityChecksHeight() {
      var rectangle = new Rectangle(40, 0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestRectangleConstructorSanityChecksNegativeWidth() {
      var rectangle = new Rectangle(-10, 50);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestRectangleConstructorSanityChecksNegativeHeight() {
      var rectangle = new Rectangle(10, -50);
    }
    //[TestMethod]
    //public void TestEmptyRectangleConstructor() {
    //  var rectangle = new Rectangle();
    //}

    [TestMethod]
    public void TestScaleRectangle200() {
      var shape = new Rectangle(10, 15);
      shape.Scale(200);

      Assert.AreEqual(shape.Width, 20);
      Assert.AreEqual(shape.Height, 30);
    }

    [TestMethod]
    public void TestScaleRectangle150() {
      var shape = new Rectangle(10, 15);
      shape.Scale(150);

      Assert.AreEqual(shape.Width, 15);
      Assert.AreEqual(shape.Height, (decimal)22.5);
    }

    [TestMethod]
    public void TestScaleRectangle100() {
      var shape = new Rectangle(10, 15);
      shape.Scale(100);

      Assert.AreEqual(shape.Width, 10);
      Assert.AreEqual(shape.Height, 15);
    }

    [TestMethod]
    public void TestScaleRectangle37() {
      var shape = new Rectangle(10, 15);
      shape.Scale(37);

      Assert.AreEqual(shape.Width, (decimal)3.7);
      Assert.AreEqual(shape.Height, (decimal)5.55);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    public void TestScaleRectangle0() {
      var shape = new Rectangle(10, 15);
      shape.Scale(0);

    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    public void TestScaleRectangleneg5() {
      var shape = new Rectangle(10, 15);
      shape.Scale(-5);
    }

    [TestMethod]
      public void TestSidesCount(){
          var shape = new Rectangle(1,2);

      Assert.AreEqual(4,shape.SidesCount);
      }

    [TestMethod]
    public void TestRectangleArea() {
      var shape = new Rectangle(1, 5);
      Assert.AreEqual(shape.Area(), 5);
    }

    [TestMethod]
    public void TestRectangleBigArea() {
      var shape = new Rectangle(10, 100);
      Assert.AreEqual(shape.Area(), 1000);
    }

    [TestMethod]
    public void TestRectanglePerimeter() {
      var shape = new Rectangle(10, 10);
      Assert.AreEqual(shape.Perimeter(), 40);
    }

    [TestMethod]
    public void TestRectangleOtherPerimeter() {
      var shape = new Rectangle(10, 100);
      Assert.AreEqual(shape.Perimeter(), 220);
    }

    [TestMethod]
    public void DefaultRectangleColor() {
      var shape = new Rectangle(5,5);

      Assert.AreEqual(shape.FillColor, System.Drawing.Color.Bisque);
      Assert.AreEqual(shape.BorderColor, System.Drawing.Color.Tomato);
    }

    [TestMethod]
    public void TestScalingBothWays() {
      var shape = new Rectangle(5, 5);
      shape.Scale(50);
      shape.Scale(200);
      Assert.AreEqual(shape.Height, 5);
      Assert.AreEqual(shape.Width, 5);

    }
  }
}
