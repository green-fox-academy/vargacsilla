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
using System.Windows.Shapes;
using GreenFox;

namespace _05_Horizontal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawHorizonatlLines(20, 30);
            DrawHorizonatlLines(190, 200);
            DrawHorizonatlLines(270, 200);
        }

        private void DrawHorizonatlLines(double x, double y)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(x, y, x + 50, y);
        }
    }
}
