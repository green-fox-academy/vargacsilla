using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //var squaredPositives = from number in n
            //                       where number > 0
            //                       select number * number;

            var squaredPositives = n.Where(number => number > 0).Select(number => number * number);

            foreach (var number in squaredPositives)
            {
                Console.WriteLine(number);
            }
            Console.Read();
        }
    }
}
