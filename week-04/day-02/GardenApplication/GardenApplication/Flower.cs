using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Flower : Plant
    {
        public override double Absorbtion { get; protected set; } = 0.75;
        public override double WaterCapacity { get; protected set; } = 5;

        public Flower(ConsoleColor color)
        {
            this.currentWater = 0;
            this.color = color;
        }


    }
}
