using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Tree : Plant
    {
        public override double Absorbtion { get; protected set; } = 0.4;
        public override double WaterCapacity { get; protected set; } = 10;

        public Tree(ConsoleColor color)
        {
            this.currentWater = 0;
            this.color = color;
        }
    }
}
