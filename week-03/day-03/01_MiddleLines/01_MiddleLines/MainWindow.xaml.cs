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

namespace _01_MiddleLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Red);
            var startPointRed = new Point(0, canvas.Width/2);
            var endPointRed = new Point(canvas.Width, canvas.Width/2);
            foxDraw.DrawLine(startPointRed, endPointRed);

            foxDraw.StrokeColor(Colors.ForestGreen);
            var startPointGreen = new Point(canvas.Width/2, 0);
            var endPointGreen = new Point(canvas.Width / 2, canvas.Height);
            foxDraw.DrawLine(startPointGreen, endPointGreen);
        }
    }
}
