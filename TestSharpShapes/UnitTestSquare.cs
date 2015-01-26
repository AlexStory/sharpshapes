using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes {
  [TestClass]
  public class UnitTestSquare {
    
    [TestMethod]
    public void TestSquareConstructor() {
      var shape = new Square(40);

      Assert.AreEqual(40, shape.Width);
      Assert.AreEqual(40, shape.Height);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestSquareConstructorSanityChecksWidth() {
      var square = new Square(0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestSquareConstructorSanityChecksNegativeWidth() {
      var square = new Square(-10);
    }


    //[TestMethod]
    //public void TestEmptySquareConstructor() {
    //  var Square = new Square();
    //}

    [TestMethod]
    public void TestScaleSquare200() {
      var shape = new Square(10);
      shape.Scale(200);

      Assert.AreEqual(shape.Width, 20);
    }

    [TestMethod]
    public void TestScaleSquare150() {
      var shape = new Square(10);
      shape.Scale(150);

      Assert.AreEqual(shape.Width, 15);
    }

    [TestMethod]
    public void TestScaleSquare100() {
      var shape = new Square(10);
      shape.Scale(100);

      Assert.AreEqual(shape.Width, 10);
    }

    [TestMethod]
    public void TestScaleSquare37() {
      var shape = new Square(10);
      shape.Scale(37);

      Assert.AreEqual(shape.Width, (decimal)3.7);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestScaleSquare0() {
      var shape = new Square(10);
      shape.Scale(0);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestScaleSquareneg5() {
      var shape = new Square(10);
      shape.Scale(-5);
    }

    [TestMethod]
    public void TestSidesCount() {
      var shape = new Square(1);

      Assert.AreEqual(4, shape.SidesCount);
    }

    [TestMethod]
    public void TestSquareArea() {
      var shape = new Square(5);
      Assert.AreEqual(shape.Area(), 25);
    }

    [TestMethod]
    public void TestSquareBigArea() {
      var shape = new Square(100);
      Assert.AreEqual(shape.Area(), 10000);
    }

    [TestMethod]
    public void TestSquarePerimeter() {
      var shape = new Square(10);
      Assert.AreEqual(shape.Perimeter(),40);
    }

    [TestMethod]
    public void TestSquareOtherPerimeter() {
      var shape = new Square(100);
      Assert.AreEqual(shape.Perimeter(), 400);
    }

    [TestMethod]
    public void DefaultSquareColor() {
      var shape = new Square(5);

      Assert.AreEqual(shape.FillColor, System.Drawing.Color.Bisque);
      Assert.AreEqual(shape.BorderColor, System.Drawing.Color.Tomato);
    }

    [TestMethod]
    public void TestScalingBothWays() {
      var shape = new Square(5);
      shape.Scale(50);
      shape.Scale(200);
      Assert.AreEqual(shape.Height, 5);
      Assert.AreEqual(shape.Width, 5);

    }
  }
}
