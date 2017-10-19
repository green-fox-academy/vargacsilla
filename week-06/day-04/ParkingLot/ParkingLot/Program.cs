using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new ParkingLot(256);

            var carTypeCount = from car1 in parkingLot.cars
                               group car1 by car1.Type into carsByType
                               select new { carsByType.Key, Occurance = carsByType.Count() };

            foreach (var item in carTypeCount)
            {
                Console.WriteLine($"{item.Key} : {item.Occurance}");
            }

            Console.WriteLine();

            var carColorCount = from car2 in parkingLot.cars
                                group car2 by car2.Color into carsByColor
                                select new { carsByColor.Key, Value = carsByColor.Count() };

            foreach (var item in carColorCount)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            var mostFrequentCar = parkingLot.cars
                .GroupBy(car => new { Color = car.Color, Type = car.Type })
                .ToDictionary(item => item.Key, item => item.Count())
                .OrderByDescending(item => item.Value)
                .First();

            Console.WriteLine($"{mostFrequentCar.Key.Color} {mostFrequentCar.Key.Type} occurs {mostFrequentCar.Value} times " +
                $"- this is the most frequent cartype.");
            Console.Read();


        }
    }
}
