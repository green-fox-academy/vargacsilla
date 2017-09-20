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

namespace _08_PositionSquare
{
public partial class MainWindow : Window
    {
        public static Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            int squareNum = 3;
            for (int i = 0; i < squareNum; i++)
            {
            DrawFixedSizeRect(rnd.Next(250), rnd.Next(250));
            }
        }

        private void DrawFixedSizeRect(double x, double y)
        {
            double a = 50;
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawRectangle(x, y, a, a);
        }
    }
}
