﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes {
  public class Rectangle : Shape {
 

    public Rectangle(decimal width, decimal height) {
      if (height < 1 || width < 1) { throw new ArgumentException(); }
      this.height = height;
      this.width = width;
    }

    private decimal width;
    public decimal Width {
      get { return width; } 
    }


    private decimal height;
    public decimal Height {
      get { return height; }
    }

    public override decimal Area() {
      return Height * Width;
    }

    public override decimal Perimeter() {
      return (Height * 2) + (Width * 2);
    }

    public override int SidesCount {
      get { return 4; }
    }

    public override void Scale(int percent) {
      if (percent < 1) { throw new ArgumentException(); }
      height =  height * percent / 100;
      width =  width * percent / 100;

    }

  }
}