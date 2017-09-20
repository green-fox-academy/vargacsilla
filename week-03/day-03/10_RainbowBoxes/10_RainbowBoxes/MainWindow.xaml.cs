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

namespace _10_RainbowBoxes
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
                DrawRainbowSquare(i, i);
            }
        }

        private void DrawRainbowSquare(double a, double colorNum)
        {
            var foxDraw = new FoxDraw(canvas);

            Color color = new Color();
            color = Color.FromRgb((byte)(colorNum % 255), 200, 0);
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
