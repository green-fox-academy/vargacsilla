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
            var myCarrier = new Carrier(150, 500);
            myCarrier.AddAircraft("F16");
            myCarrier.AddAircraft("F16");
            myCarrier.AddAircraft("F35");

            Console.Read();
        }
    }
}
