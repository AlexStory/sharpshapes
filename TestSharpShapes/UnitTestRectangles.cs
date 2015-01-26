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
  }
}
