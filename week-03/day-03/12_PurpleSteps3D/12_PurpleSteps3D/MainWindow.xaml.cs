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

namespace _12_PurpleSteps3D
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);

            double x = 10;
            double y = 10;
            double a = 10;

            for (int i = 0; x < canvas.Width * 2 / 3; i++)
            {
                for (int j = 0; y < canvas.Height * 2 / 3; j++)
                {
                    foxDraw.FillColor(Colors.Purple);
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.DrawRectangle(x, y, a, a);
                    x += a;
                    y += a;
                    a += 10;
                }
            }
        }
    }
}
