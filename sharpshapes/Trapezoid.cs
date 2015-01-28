using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes {
  public class Trapezoid : Quadrilateral {
   
    private decimal base1;
    public decimal Base1 {
      get { return base1; }
    }

    private decimal base2;
    public decimal Base2 {
      get { return base2; }
    }

    private decimal height;
    public decimal Height{
      get { return height;}
    }


    public Trapezoid(int base1, int base2, int height) {
      if (base1 < 1 || base2 < 1 || height < 1) { throw new ArgumentException(); }
      this.base1 = base1;
      this.base2 = base2;
      this.height = height;
    }

    public override void Scale(int percent) {
      throw new NotImplementedException();
    }

    public override decimal Area() {
      return ((Base2 + Base1) / 2) * Height;
    }

    public override decimal Perimeter() {
      throw new NotImplementedException();
    }
  }
}
