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

namespace _02_ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var foxDraw = new FoxDraw(canvas);
            
            double x1 = 10;
            double y1 = 80;
            double x2 = 120;
            double y2 = 100;

            foxDraw.StrokeColor(Colors.LavenderBlush);
            foxDraw.DrawLine(x1, y1, x2, y1);

            foxDraw.StrokeColor(Colors.DeepPink);
            foxDraw.DrawLine(x1, y2, x2, y2);

            foxDraw.StrokeColor(Colors.LightBlue);
            foxDraw.DrawLine(x1, y1, x1, y2);

            foxDraw.StrokeColor(Colors.Lime);
            foxDraw.DrawLine(x2, y1, x2, y2);

        }
    }
}
