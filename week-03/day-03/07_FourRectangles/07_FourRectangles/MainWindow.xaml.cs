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

namespace _07_FourRectangles
{
    public partial class MainWindow : Window
    {
        public static Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();

            int rectNum = 4;
            for (int i = 0; i < rectNum; i++)
            {
                DrawRandomColoredRect(250, 250, 50, 50);
            }
        }

        private void DrawRandomColoredRect(int maxx, int maxy, int maxa, int maxb)
        {
            var foxDraw = new FoxDraw(canvas);
            double x = rnd.Next(maxx);
            double y = rnd.Next(maxy);
            double a = rnd.Next(maxa/2, maxa);
            double b = rnd.Next(maxb/2, maxb);

            Color color = new Color();
            color = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));

            foxDraw.FillColor(color);
            foxDraw.DrawRectangle(x, y, a, b);
        }
    }
}
