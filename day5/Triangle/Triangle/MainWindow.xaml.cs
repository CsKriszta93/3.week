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
using GreenFox;
using System.Windows.Shapes;

namespace Triangle
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Triangle(0, 0, 300, 6);   
        }
        public void Triangle(double coor1, double coor2, double size, int n)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            var left = new Point(coor1, coor2);
            var right = new Point(coor1 + size / 2, coor2);
            var top = new Point(coor1 + size / 4, coor2 + size / 2);
            Point[] points = { left, right, top };
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Transparent);
            foxDraw.DrawPolygon(points);

            var left2 = new Point(coor1 + size / 2, coor2);
            var bottom2 = new Point(coor1 + size, coor2);
            var top2 = new Point(coor1 + size - (size / 4), coor2 + size / 2);
            Point[] points2 = { left2, bottom2, top2 };
            foxDraw.DrawPolygon(points2);

            var left3 = new Point(coor1 + size / 4, coor2 + size / 2);
            var bottom3 = new Point(coor1 + size - (size / 4), coor2 + size / 2);
            var top3 = new Point(coor1 + size / 2, coor2 + size);
            Point[] points3 = { left3, bottom3, top3 };
            foxDraw.DrawPolygon(points3);

            if (n > 0)
            {
                Triangle(coor1, coor2, size / 2, n - 1);
                Triangle(coor1 + size / 2, coor2, size / 2, n - 1);
                Triangle(coor1 + size / 4, coor2 + size / 2, size / 2, n - 1);
            }
        }
    }
}

    
   
