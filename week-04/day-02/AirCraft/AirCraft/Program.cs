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
            var myCarrier = new Carrier(20, 500);
            myCarrier.AddPlane("F16");
            myCarrier.AddPlane("F16");
            myCarrier.AddPlane("F35");
            myCarrier.FillPlanes();

            Console.Read();
        }
    }
}
