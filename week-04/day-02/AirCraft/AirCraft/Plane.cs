using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft
{
    class Plane
    {
        int maxAmmo;
        int baseDamage;
        int currentAmmo;

        public Plane()
        {
            maxAmmo = 10;
            baseDamage = 40;
            currentAmmo = 0;
        }

        public void Fight()
        {

        }

        public void Refill()
        {

        }

        public string GetPlaneType()
        {
            return "";
        }

        public string Getstatus()
        {
            return "";
        }
    }
}
