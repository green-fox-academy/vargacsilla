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

        public int Fight()
        {
            int damage = currentAmmo * baseDamage;
            currentAmmo = 0;
            return damage;
        }

        public int Refill(int plusAmmo)
        {
            int leftoverAmmo = (currentAmmo + plusAmmo) - maxAmmo;
            if (leftoverAmmo < 0)
            {
                currentAmmo = (currentAmmo + plusAmmo) % maxAmmo;
                return 0;
            }
            else
            {
                currentAmmo = maxAmmo;
                return leftoverAmmo;
            }
        }

        public string GetPlaneType()
        {
            return GetType().Name;
        }

        public string GetStatus()
        {

            string status = string.Format($"Type: {GetPlaneType()} | Ammo: {currentAmmo} | Base damage: {baseDamage} | All damage: {currentAmmo * baseDamage}");
            return status;
        }
    }
}
