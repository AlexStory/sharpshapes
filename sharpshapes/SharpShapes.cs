using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SharpShapes{
    public abstract class SharpShapes{

      public Color BorderColor { set; get; }
      public Color FillColor { set; get; }
      public virtual int SidesCount { get; }
      
      abstract public  void scale(int percent);

      abstract public decimal Area();

      abstract public int Perimeter();
  }    
}
