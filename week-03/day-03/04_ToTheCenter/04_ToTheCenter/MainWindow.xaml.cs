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

namespace _04_ToTheCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LineToCenter(10, 40);
            LineToCenter(190, 250);
            LineToCenter(50, 240);
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
