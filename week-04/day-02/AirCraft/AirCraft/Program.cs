using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane1 = new F16();
            var plane2 = new F35();
            Console.WriteLine(plane1.GetStatus());
            Console.WriteLine("expected: 4, ");
            Console.Write(plane1.Refill(12));
            Console.WriteLine("excpected: 2, ");
            Console.Write(plane1.Refill(2));
            Console.WriteLine(plane1.GetStatus());

            Console.WriteLine(plane2.GetStatus());
            Console.WriteLine("expected: 0, ");
            Console.Write(plane2.Refill(9));
            Console.WriteLine(plane2.GetStatus());
            Console.Read();
        }
    }
}
