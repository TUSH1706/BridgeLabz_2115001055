using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleandTransportSystem
{
    public class Vehicle
    {
        public int maxSpeed;
        public string fuelType;

        public Vehicle(int maxSpeed, string fuelType)
        {
            this.maxSpeed = maxSpeed;
            this.fuelType = fuelType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {maxSpeed} km/h, Fuel Type: {fuelType}");
        }
    }

    class Car: Vehicle
    {
        public int seatCapacity;

        public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
        {
            this.seatCapacity = seatCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Car....");
            base.DisplayInfo();
            Console.WriteLine($"Seat Capacity: {seatCapacity}");

        }

    }

    class Truck: Vehicle
    {
        public int payloadCapacity;

        public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
        {
            this.payloadCapacity = payloadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Truck....");
            base.DisplayInfo();
            Console.WriteLine($"Payload Capacity: {payloadCapacity}");

        }

    }

    class Motorcycle : Vehicle
    {
        public bool hasSideCar;

        public Motorcycle(int maxSpeed, string fuelType, bool hasSideCar) : base(maxSpeed, fuelType)
        {
            this.hasSideCar = hasSideCar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Motorcycle....");
            base.DisplayInfo();
            Console.WriteLine($"Has SideCar?: {hasSideCar}");

        }

    }
}
