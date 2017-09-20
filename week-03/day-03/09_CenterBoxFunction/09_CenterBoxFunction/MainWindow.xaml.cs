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

namespace _09_CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public static Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            int squareNum = 300;
            for (int i = 0; i < squareNum; i++)
            {
                DrawCenterSquare(i);
                //DrawCenterSquare(rnd.Next(300));
            }
        }

        private void DrawCenterSquare (double a)
        {
            var foxDraw = new FoxDraw(canvas);

            Color color = new Color();
            color = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
            foxDraw.StrokeColor(color);

            Color fillColor = new Color();
            fillColor = Color.FromArgb(0, 0, 0, 0);
            foxDraw.FillColor(fillColor);

            double centerZ = canvas.Width / 2 - a / 2;
            double centerY = canvas.Height / 2 - a / 2;
            foxDraw.DrawRectangle(centerZ, centerY, a, a);
        }
    }
}
