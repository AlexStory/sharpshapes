using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using SharpShapes;


namespace TestSharpShapes {

  public class myShape : Shape {

    public override decimal Area() {
      throw new NotImplementedException();
    }

    public override decimal Perimeter() {
      throw new NotImplementedException();
    }

    public override void Scale(int percent) {
      throw new NotImplementedException();
    }

    public override int SidesCount {
      get { throw new NotImplementedException(); }
    }

  }
  
  [TestClass]

  public class UnitTestShape {
    
    [TestMethod]
    public void TestSettingBorderColor() {
      var shape = new myShape();
      shape.BorderColor = Color.AliceBlue;
      
      Assert.AreEqual(Color.AliceBlue, shape.BorderColor);
    }

    [TestMethod]
    public void TestSettingFillColor() {
      var shape = new myShape();
      shape.FillColor = Color.AliceBlue;

      Assert.AreEqual(Color.AliceBlue, shape.FillColor);
    }

    [TestMethod]
    public void DefaultFillColor() {
      var shape = new myShape();

      Assert.AreEqual(shape.FillColor, Color.Bisque);
    }

    [TestMethod]
    public void DefaultBorderColor() {
      var shape = new myShape();

      Assert.AreEqual(Color.Tomato, shape.BorderColor);
    }
  }
}
 
