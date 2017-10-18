using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //var evenNumbers = (from numbers in n
            //                  where numbers % 2 == 0
            //                  select numbers).ToList<int>();

            var evenNumbers = n.Where(num => num % 2 == 0);

            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.Read();
        }
    }
}
