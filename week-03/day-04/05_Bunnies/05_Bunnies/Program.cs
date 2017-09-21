using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountEars(23));
            Console.ReadLine();
        }

        private static int CountEars(int n)
        {
            if (n == 0)
                return 0;
            else
                return 2 + CountEars(n - 1);
        }
    }
}
