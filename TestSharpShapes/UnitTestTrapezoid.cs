using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes {
  [TestClass]
  public class TrapezoidTest {
    [TestMethod]
    public void TestTrapezoidConstructor() {
      var shape = new Trapezoid(5, 8, 2);

      Assert.AreEqual(shape.Base1, 5);
      Assert.AreEqual(shape.Base2, 8);
      Assert.AreEqual(shape.Height, 2);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    public void InvalidTrapezoidConstructorB1() {
      var shape = new Trapezoid(0, 3, 5);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    public void InvalidTrapezoidConstructorB2() {
      var shape = new Trapezoid(5, 0, 5);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    public void InvalidTrapezoidConstructorH() {
      var shape = new Trapezoid(2, 3, 0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NegativeTrapezoidTestb2() {
    
      var shape = new Trapezoid(4, -2, 3);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NegativeTrapezoidTestB1() {
    
      var shape = new Trapezoid(-4, 2, 3);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NegativeTrapezoidTestHeight() {
    
      var shape = new Trapezoid(4, 2, -3);
    }

    [TestMethod]
      public void TestScaleTrap200()
      {
          var shape = new Trapezoid(5,8,2);
        shape.Scale(200);

        Assert.AreEqual(shape.Base1, 10);
        Assert.AreEqual(shape.Base2, 16);
        Assert.AreEqual(shape.Height, 4);
    }

    [TestMethod]
    public void TestScaleTrap150() {
      var shape = new Trapezoid(5, 8, 2);
      shape.Scale(150);

      Assert.AreEqual(shape.Base1, (decimal)7.5);
      Assert.AreEqual(shape.Base2, (decimal)12);
      Assert.AreEqual(shape.Height, (decimal)3);
    }

    [TestMethod]
    public void TestScaleTrap100() {
      var shape = new Trapezoid(5,8,2);
      shape.Scale(100);

      Assert.AreEqual(shape.Base1, 5);
      Assert.AreEqual(shape.Base2, 8);
      Assert.AreEqual(shape.Height, 2);
    }

    [TestMethod]
    public void TestScaleTrap37() {
      var shape = new Trapezoid(5,8,2);
      shape.Scale(37);

      Assert.AreEqual(shape.Base1, (decimal)1.85);
      Assert.AreEqual(shape.Base2, (decimal)2.96);
      Assert.AreEqual(shape.Height, (decimal)0.74);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    public void TestScaleTrap0() {
      var shape = new Trapezoid(5,8,2);
      shape.Scale(0);

    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    public void TestScaleTrapneg5() {
      var shape = new Trapezoid(5,8,2);
      shape.Scale(-5);
    }

     [TestMethod]
      public void TestTrapSidesCount(){
          var shape = new Trapezoid(5,8,2);

      Assert.AreEqual(4,shape.SidesCount);
      }

    [TestMethod]
    public void TestTrapArea() {
      var shape = new Trapezoid(5,8,2);
      Assert.AreEqual(shape.Area(), 13);
    }

    [TestMethod]
    public void TestTrapBigArea() {
      var shape = new Trapezoid(10,16,4);
      Assert.AreEqual(shape.Area(), 52);
    }

    [TestMethod]
    public void TestTrapPerimeter() {
      var shape = new Trapezoid(5,8,2);
      Assert.AreEqual(Math.Round(shape.Perimeter(),2),(decimal) 16.61);
    }
    
    [TestMethod]
    public void TestTrapOtherPerimeter() {
      var shape = new Trapezoid(10,16, 4);
      Assert.AreEqual(Math.Round(shape.Perimeter(), 2),(decimal) 33.21);
    }

    [TestMethod]
    public void DefaultTrapColor() {
      var shape = new Trapezoid(5,8,2);

      Assert.AreEqual(shape.FillColor, System.Drawing.Color.Bisque);
      Assert.AreEqual(shape.BorderColor, System.Drawing.Color.Tomato);
    }

    [TestMethod]
    public void TestScalingTrapBothWays() {
      var shape = new Trapezoid(5,8,2);
      shape.Scale(50);
      shape.Scale(200);
      Assert.AreEqual(shape.Base1, 5);
      Assert.AreEqual(shape.Base2, 8);
      Assert.AreEqual(shape.Height, 2);

    }



  }
}
