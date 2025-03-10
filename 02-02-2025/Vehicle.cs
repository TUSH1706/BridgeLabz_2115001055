using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_2025
{
    public class Vehicle
    {
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }

        private static double registrationFee = 500.00;

        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner: {OwnerName}, Vehicle Type: {VehicleType}, Registration Fee: ${registrationFee}");
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }
    }

}
