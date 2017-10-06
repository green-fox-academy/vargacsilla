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

        public Carrier(int ammoStore, int healthPoints)
        {
            planeList = new List<Plane>();
            this.ammoStore = ammoStore;
            this.healthPoints = healthPoints;
        }

        public void AddPlane(string type)
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

        public int FillPlanes()
        {
            if (ammoStore == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                planeList = OrderPlaneList();

                for (int i = 0; i < planeList.Count; i++)
                {
                    ammoStore = planeList[i].Refill(ammoStore);
                    if (ammoStore <= 0)
                    {
                        return ammoStore = 0;
                    }
                }
                return ammoStore;
            }
        }

        private List<Plane> OrderPlaneList()
        {
            var f35List = new List<Plane>();
            var f16List = new List<Plane>();

            foreach (var plane in planeList)
            {
                if (plane.GetPlaneType() == "F35")
                {
                    f35List.Add(plane);
                }
                else
                {
                    f16List.Add(plane);
                }
            }

            var orderedPlaneList = new List<Plane>();
            orderedPlaneList.AddRange(f35List);
            orderedPlaneList.AddRange(f16List);

            return orderedPlaneList;
        }
    }
}
