using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _13_Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double x = 0;
            double y = 0;
            double a = canvas.Width / 10;

            for (int i = 0; y < canvas.Height; i++)
            {
                if (i % 2 != 0)
                {
                    x += a;
                }
                
                for (int j = 0; x < canvas.Width; j++)
                {
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.DrawRectangle(x, y, a, a);
                    x += 2 * a;
                }
                x = 0;
                y += a;
            }
        }
    }
}