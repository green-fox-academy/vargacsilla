using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            //var squaredBiggerThan20 = from number in n
            //                          where (Math.Pow(number, 2)) > 20
            //                          select number;

            var squaredBiggerThan20 = n.Where(num => (Math.Pow(num, 2)) > 20).Select(num => num);

            foreach (var number in squaredBiggerThan20)
            {
                Console.WriteLine(number);
            }
            Console.Read();
        }
    }
}
