using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Plant
    {
        public virtual double Absorbtion { get; protected set; } = 1;
        public virtual double WaterCapacity { get; protected set; } = 1;

        public ConsoleColor color;
        public double currentWater;

        public void Water(double amount)
        {
            currentWater += amount * Absorbtion;
        }

    }
}
