using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft
{
    class Carrier
    {
        List<Plane> planeList;
        int healthPoints;
        int ammoStore;
        int currentAmmo = 0;
        int aircraftCount;

        public Carrier(int ammoStore, int healthPoints)
        {
            planeList = new List<Plane>();
            this.ammoStore = ammoStore;
            this.healthPoints = healthPoints;
        }

        public void AddAircraft(string type)
        {
            if (type == "F16")
            {
                planeList.Add(new F16());
            }
            if (type == "F35")
            {
                planeList.Add(new F35());
            }
        }
    }
}
