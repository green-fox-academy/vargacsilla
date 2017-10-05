using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGarden = new Garden();
            myGarden.CreateMyGarden();
            myGarden.WaterTheGarden(40);
            myGarden.WaterTheGarden(70);
            Console.Read();
        }
    }
}
