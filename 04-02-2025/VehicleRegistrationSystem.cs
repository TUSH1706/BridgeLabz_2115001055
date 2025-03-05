using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationSystem
{
    public class Vehicle
    {
        public static double RegistrationFee = 5000.00;

        // Readonly variable ensures each vehicle has a unique registration number
        public readonly int RegistrationNumber;
        private static int registrationCount = 1000; // Keeps track of registration numbers

        private string OwnerName;
        private string VehicleType;

        public Vehicle(string ownerName, string vehicleType)
        {
            this.RegistrationNumber = ++registrationCount; // Assign unique registration number
            this.OwnerName = ownerName;
            this.VehicleType = vehicleType;
        }

        // Static method to update registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine($"Registration fee updated to {RegistrationFee}.");
        }

        public string GetVehicleDetails()
        {
            return $"Registration Number: {RegistrationNumber}\nOwner: {OwnerName}\nVehicle Type: {VehicleType}\nRegistration Fee: {RegistrationFee}";
        }

        // Method to check if object is of type Vehicle using 'is'
        public static void DisplayVehicleDetails(object obj)
        {
            if (obj is Vehicle vehicle)
            {
                Console.WriteLine(vehicle.GetVehicleDetails());
            }
            else
            {
                Console.WriteLine("The object is not a Vehicle.");
            }
        }
    }
}
