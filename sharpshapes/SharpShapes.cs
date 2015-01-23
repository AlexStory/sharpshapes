using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SharpShapes{
    public abstract class SharpShapes{
      /// <summary>
      /// This is the color of the shape's border whend drawn on the screen
      /// </summary>
      public Color BorderColor { set; get; }
      /// <summary>
      /// This is the color of the inside of the shape when drawn on the screen
      /// </summary>
      public Color FillColor { set; get; }

      /// <summary>
      /// Number of sides a shape has
      /// </summary>
      public virtual int SidesCount { get; }
      
      /// <summary>
      /// Scales the size of the shape based on a perventage value
      /// </summary>
      /// <param name="percent">
      /// The integer percent you wish to scale the percent by, anything larger than 100 will increase the size
      /// </param>
      abstract public  void scale(int percent);

      /// <summary>
      /// Function to find the area of shape
      /// </summary>
      /// <returns> the Area of the shape</returns>
      abstract public decimal Area();

      /// <summary>
      /// returns the perimiter value of the shape
      /// </summary>
      /// <returns>the perimiter of the shape</returns>
      abstract public int Perimeter();
  }    
}
