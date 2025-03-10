using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManage
{
    interface Refuelable{   
        void Refuel();
    }

    class Vehicle
    {
        public int maxSpeed;
        public string model;

        public Vehicle(int maxSpeed, string model)
        {
            this.maxSpeed = maxSpeed;
            this.model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Model: {model}, Max Speed: {maxSpeed} km/h");
        }
    }

    class ElectricVehicle : Vehicle
    {
        public int batteryCapacity;

        public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
            : base(maxSpeed, model)
        {
            this.batteryCapacity = batteryCapacity;
        }

        public void Charge()
        {
            Console.WriteLine($"{model} is charging with {batteryCapacity} kWh capacity.");
        }
    }

    class PetrolVehicle : Vehicle, Refuelable
    {
        public int fuelTankCapacity;

        public PetrolVehicle(int maxSpeed, string model, int fuelTankCapacity)
            : base(maxSpeed, model)
        {
            this.fuelTankCapacity = fuelTankCapacity;
        }

        public void Refuel()
        {
            Console.WriteLine($"{model} is refueling with {fuelTankCapacity} liters capacity.");
        }
    }

}
