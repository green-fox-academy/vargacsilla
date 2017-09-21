using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown(40);
            Console.ReadLine();
        }

        private static int CountDown(int n)
        {
            if (n == 0)
                return n = 1;
            else
                Console.WriteLine(n);
                return CountDown(n - 1);
        }
    }
}
