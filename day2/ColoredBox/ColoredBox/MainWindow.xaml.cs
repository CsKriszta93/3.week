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

namespace ColoredBox
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
            foxDraw.BackgroundColor(Colors.Crimson);
            //foxDraw.DrawRectangle(10, 10, 150, 50);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(100, 100, 250, 100);

            foxDraw.StrokeColor(Colors.Azure);
            foxDraw.DrawLine(100, 100, 100, 200);

            foxDraw.StrokeColor(Colors.BlueViolet);
            foxDraw.DrawLine(250, 100, 250, 200);

            foxDraw.StrokeColor(Colors.DeepPink);
            foxDraw.DrawLine(100, 200, 250, 200);




        }

    }
}
