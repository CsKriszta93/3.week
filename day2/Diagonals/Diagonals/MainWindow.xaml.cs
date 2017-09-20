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

namespace Diagonals
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
            foxDraw.BackgroundColor(Colors.Beige);
            var canvasheight = canvas.Height;
            var canvaswidth = canvas.Width;

            foxDraw.StrokeColor(Colors.LightGreen);
            var startPoint = new Point(0, 0);
            var endPoint = new Point(canvasheight, canvaswidth);
            foxDraw.DrawLine(startPoint, endPoint);

            foxDraw.StrokeColor(Colors.LightGreen);
            var startPoint2 = new Point(0, canvasheight);
            var endPoint2 = new Point(canvaswidth, 0);
            foxDraw.DrawLine(startPoint2, endPoint2);


        }
    }
}
