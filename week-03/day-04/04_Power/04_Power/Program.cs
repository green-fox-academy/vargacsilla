using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToThePower(2, 10));
            Console.Read();
        }

        private static int ToThePower(int n, int p)
        {
            if (p == 0)
                return 1;
            else
                return n * ToThePower(n, p - 1);
        }
    }
}
