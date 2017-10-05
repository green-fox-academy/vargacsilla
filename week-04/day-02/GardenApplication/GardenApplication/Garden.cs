using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Garden
    {
        List<Plant> myGarden = new List<Plant>();

        public void CreateMyGarden()
        {
            myGarden.Add(new Flower(ConsoleColor.Yellow));
            myGarden.Add(new Flower(ConsoleColor.Blue));
            myGarden.Add(new Tree(ConsoleColor.DarkMagenta));
            myGarden.Add(new Tree(ConsoleColor.DarkYellow));
        }

        public void AddToGarden(Plant myPlant)
        {
            myGarden.Add(myPlant);
        }

        public void WaterTheGarden(double amount)
        {
            var thirstyPlantList = GetThirstyPlants();
            foreach (var thirstyPlant in thirstyPlantList)
            {
                thirstyPlant.Water(amount / thirstyPlantList.Count);
            }
            Console.WriteLine("Watering with {0}", amount);
            WhatsInMyGarden();
        }

        public void WhatsInMyGarden()
        {
            foreach (var plant in myGarden)
            {
                string isThirsty = "needs";
                if (plant.WaterCapacity <= plant.currentWater)
                {
                    isThirsty = "doesn't need";
                }
                Console.WriteLine("The {0} {1} {2} water.", plant.color, plant.GetType().Name, isThirsty);
            }
            Console.WriteLine();
        }

        public List<Plant> GetThirstyPlants()
        {
            var thirstyList = new List<Plant>();
            foreach (var plant in myGarden)
            {
                if (plant.currentWater <= plant.WaterCapacity)
                {
                    thirstyList.Add(plant);
                }
            }
            return thirstyList;
        }
    }
}
