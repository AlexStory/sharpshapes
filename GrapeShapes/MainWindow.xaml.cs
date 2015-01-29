using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Reflection;
using SharpShapes;

namespace GrapeShapes {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      PopulateClassList();
      var square = new Square(30);
      square.FillColor = System.Drawing.Color.AliceBlue;
      square.BorderColor = System.Drawing.Color.BurlyWood;

      var square2 = new Square(200);
      square2.BorderColor = System.Drawing.Color.Navy;
      square2.FillColor = System.Drawing.Color.Fuchsia;
      DrawSquare(1, 50, square);
      DrawSquare(50, 5, square2);
    }

    private void DrawSquare(int x, int y, Square size) {
      System.Windows.Shapes.Polygon myPolygon = new System.Windows.Shapes.Polygon();

      SolidColorBrush border = new SolidColorBrush();
      border.Color = Color.FromArgb(size.BorderColor.A, size.BorderColor.R, size.BorderColor.G, size.BorderColor.B);

      SolidColorBrush fill = new SolidColorBrush();
      fill.Color = Color.FromArgb(size.FillColor.A, size.FillColor.R, size.FillColor.G, size.FillColor.B);

      myPolygon.Stroke = border;
      myPolygon.Fill = fill;
      myPolygon.StrokeThickness = 2;
      myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
      myPolygon.VerticalAlignment = VerticalAlignment.Center;
      Point point1 = new Point(x, y);
      Point point2 = new Point(x, y + (double)size.Width);
      Point point3 = new Point(x + (double)size.Width, y + (double)size.Width);
      Point point4 = new Point(x + (double)size.Width, y);

      PointCollection myPointCollection = new PointCollection();
      myPointCollection.Add(point1);
      myPointCollection.Add(point2);
      myPointCollection.Add(point3);
      myPointCollection.Add(point4);

      myPolygon.Points = myPointCollection;
      myCanvas.Children.Add(myPolygon);
    }

    private void DrawRectangle() {
      System.Windows.Shapes.Polygon myPolygon = new System.Windows.Shapes.Polygon();
      myPolygon.Stroke = System.Windows.Media.Brushes.Tomato;
      myPolygon.Fill = System.Windows.Media.Brushes.Bisque;
      myPolygon.StrokeThickness = 2;
      myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
      myPolygon.VerticalAlignment = VerticalAlignment.Center;
      Point point1 = new Point(10,50);
      Point point2 = new Point(10, 80);
      Point point3 = new Point(50, 80);
      Point point4 = new Point(50, 50);

      PointCollection myPointCollection = new PointCollection();
      myPointCollection.Add(point1);
      myPointCollection.Add(point2);
      myPointCollection.Add(point3);
      myPointCollection.Add(point4);

      myPolygon.Points = myPointCollection;
      myCanvas.Children.Add(myPolygon);

    }

    private void PopulateClassList() {
      var classList = new List<string> { };
      var shapeType = typeof(Shape);
      foreach (Type type in Assembly.GetAssembly(shapeType).GetTypes()) {
        if (type.IsSubclassOf(shapeType) && !type.IsAbstract) {
          classList.Add(type.Name);
        }
        ShapeType.ItemsSource = classList;
      }
    }

    private void ShapeType_SelectionChanged(object sender, SelectionChangedEventArgs e) {

    }

    private void Button_Click(object sender, RoutedEventArgs e) {

    }
  }
}
