using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes {
  class ShapeList : ObservableCollection<string> {

    public ShapeList() {
      Add("Rectangle");
      Add("Square");
      Add("Trapezoid");
    }
  }
}
