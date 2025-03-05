using System;
using System.Collections.Generic;

// Abstract class Vehicle
public abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Type { get; set; }
    public double RentalRate { get; set; }

    public abstract double CalculateRentalCost(int days);
}

// Subclass Car
public class Car : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 0.1; 
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance Policy: XYZ123";
    }
}

// Subclass Bike
public class Bike : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 0.05; 
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance Policy: ABC456";
    }
}

// Subclass Truck
public class Truck : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 0.2;
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance Policy: DEF789";
    }
}

public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

public class Insurance
{
    private string PolicyNumber { get; set; }

    public Insurance(string policyNumber)
    {
        PolicyNumber = policyNumber;
    }

    public string GetPolicyNumber()
    {
        return PolicyNumber;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { VehicleNumber = "C123", Type = "Car", RentalRate = 50 },
            new Bike { VehicleNumber = "B456", Type = "Bike", RentalRate = 30 },
            new Truck { VehicleNumber = "T789", Type = "Truck", RentalRate = 80 }
        };

        foreach (var vehicle in vehicles)
        {
            int rentalDays = 5;
            double rentalCost = vehicle.CalculateRentalCost(rentalDays);
            Console.WriteLine($"Vehicle {vehicle.VehicleNumber} ({vehicle.Type}) rental cost for {rentalDays} days: {rentalCost}");
            if (vehicle is IInsurable insurable)
            {
                double insuranceCost = insurable.CalculateInsurance();
                Console.WriteLine($"Insurance cost: {insuranceCost}");
                Console.WriteLine($"Insurance details: {insurable.GetInsuranceDetails()}");
            }
        }
    }
}
