using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft
{
    class Plane
    {
        protected int maxAmmo;
        protected int baseDamage;
        protected int currentAmmo = 0;

        public Plane()
        {
            maxAmmo = 10;
            baseDamage = 40;
        }

        public void Fight()
        {

        }

        public void Refill()
        {

        }

        public string GetPlaneType()
        {
            string type = GetType().Name;
            return type;
        }

        public string GetStatus()
        {

            string status = string.Format($"Type: {GetPlaneType()} | Ammo: {currentAmmo} | Base damage: {baseDamage} | All damage: {currentAmmo * baseDamage}");
            return status;
        }
    }
}
