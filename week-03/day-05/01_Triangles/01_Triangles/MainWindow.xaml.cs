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

namespace _01_Triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawTriangles(0, 0, canvas.Width, 5);
        }

        private void DrawTriangles(double x, double y, double size, double depth)
        {
            var foxDraw = new FoxDraw(canvas);

            Color fillColor = new Color();
            fillColor = Color.FromArgb(0, 0, 0, 0);
            foxDraw.FillColor(fillColor);

            if (depth == 0)
            {
                return;
            }
            else
            {
                DrawOneTriangle(x, y, size/2);
                DrawOneTriangle(x + size / 2, y, size/2);
                DrawOneTriangle(x + size / 4, y + size / 2, size/2);

                DrawTriangles(x, y, size/2, depth - 1);
                DrawTriangles(x + size/2, y, size/2, depth - 1);
                DrawTriangles(x + size / 4, y + size / 2, size / 2, depth - 1);
            }
        }

        private void DrawOneTriangle(double x1, double y1, double size)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(x1, y1, x1 + size, y1);
            foxDraw.DrawLine(x1, y1, x1 + size/2, y1 + size);
            foxDraw.DrawLine(x1 + size, y1, x1 + size/2, y1 + size);
        }
    }
}
