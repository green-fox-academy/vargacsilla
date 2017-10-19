using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    

    public enum CarType
    {
        Volkswagen,
        Opel,
        BMW,
        Lada,
        Lexus
    }

    public enum CarColor
    {
        Red,
        Black,
        Silver
    }

    class Car
    {
        public CarType Type { get; }
        public CarColor Color { get;  }

        public Car(CarColor color, CarType type)
        {
            Color = color;
            Type = type;
        }
    }
}
