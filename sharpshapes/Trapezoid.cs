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

      double wing = (double)Math.Abs((this.Base1 - this.Base2) / 2);
      this.AcuteAngle = ((double)Math.Atan((double)height / (double)wing)) * ((double)180 / (double)Math.PI);
      this.ObtuseAngle = 180 - AcuteAngle;
    }

    public override void Scale(int percent) {
      if (percent < 1) { throw new ArgumentException();}
      base1 = base1 * percent / 100;
      base2 = base2 * percent / 100;
      height = height * percent / 100;
    }

    public override decimal Area() {
      return ((Base2 + Base1) / 2) * Height;
    }

    public override decimal Perimeter() {
      double db1 = (double)Base1;
      double db2 = (double)Base2;
      double dh = (double)Height;
      var s = Math.Sqrt( ( (db2 - db1) * (db2 - db1)) + (dh * dh));
      decimal ds = (decimal)s;
      return ds + Base2 + Base1;
    }

    public double AcuteAngle { get; private set; }

    public double ObtuseAngle { get; private set; }
  }
}
