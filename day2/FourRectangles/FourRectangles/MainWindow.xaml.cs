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

namespace FourRectangles
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

            foxDraw.FillColor(Colors.CornflowerBlue);
            foxDraw.DrawRectangle(20, 20, 90, 50);

            foxDraw.FillColor(Colors.DarkCyan);
            foxDraw.DrawRectangle(60, 60, 110, 80);

            foxDraw.FillColor(Colors.DarkSlateBlue);
            foxDraw.DrawRectangle(210, 170, 55, 70);

            foxDraw.FillColor(Colors.YellowGreen);
            foxDraw.DrawRectangle(80, 100, 150, 67);

        }
    }
}
