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

namespace MiddleLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Black);

            foxDraw.StrokeColor(Colors.Red);
            double height = canvas.Height / 2;
            double width = canvas.Width / 2;
            var startPoint = new Point(0, height);
            var endPoint = new Point(height * 2, width);
            foxDraw.DrawLine(startPoint, endPoint);

            foxDraw.StrokeColor(Colors.LawnGreen);
            var startPoint2 = new Point(height, 0);
            var endPoint2 = new Point(width, height * 2);
            foxDraw.DrawLine(startPoint2, endPoint2);



        }
    }
}
