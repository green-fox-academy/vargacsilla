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
            Console.WriteLine(plane1.Fight());
            Console.WriteLine(plane2.GetStatus());
            Console.Read();
        }
    }
}
