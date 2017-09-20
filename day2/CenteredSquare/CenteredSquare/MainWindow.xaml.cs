﻿using System;
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

namespace CenteredSquare
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
            foxDraw.BackgroundColor(Colors.Gainsboro);
            double squareSide = 10;
            double left = (canvas.Width - squareSide) / 2;
            double top = (canvas.Height - squareSide) / 2;
            foxDraw.DrawRectangle(left, top, squareSide, squareSide);
            
        }
    }
}