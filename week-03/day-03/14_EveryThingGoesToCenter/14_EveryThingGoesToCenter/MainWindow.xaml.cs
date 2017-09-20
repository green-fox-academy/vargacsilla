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

namespace _14_EveryThingGoesToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double x = 0;
            double y = 0;

            for (; y <= canvas.Width; y += 20)
            {
                LineToCenter(x, y);
                LineToCenter(canvas.Width, y);
            }

            for (; x < canvas.Height; x += 20)
            {
                LineToCenter(x, canvas.Height);
                LineToCenter(x, 0);
            }
            // Two lines are at the wrong place, but otherwise it's working lol:
            //
            // for (; x <= canvas.Width; )
            // {
            //    for (; y < canvas.Height; y += 20)
            //    {
            //        LineToCenter(x, y);
            //        LineToCenter(canvas.Width, y);
            //    }
            //    x += 20;
            //    LineToCenter(x, canvas.Height);
            //    LineToCenter(x, 0);
            //}
        }

        private void LineToCenter(double x, double y)
        {
            var foxDraw = new FoxDraw(canvas);
            var startPoint = new Point(x, y);
            var center = new Point(canvas.Width / 2, canvas.Height / 2);
            foxDraw.DrawLine(startPoint, center);
        }
    }
}
