using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class ParkingLot
    {
        public List<Car> cars = new List<Car>();
        Random random = new Random();

        public ParkingLot(int numberOfCars)
        {
            for (int i = 0; i < numberOfCars; i++)
            {
                cars.Add(new Car((CarColor)random.Next(typeof(CarColor).GetEnumNames().Length), 
                    (CarType)random.Next(typeof(CarType).GetEnumNames().Length)));
            }
        }
    }
}
