using System;

public static class UnitConverter
{
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("5 kilometers is equal to " + ConvertKmToMiles(5) + " miles.");
        Console.WriteLine("3 miles is equal to " + ConvertMilesToKm(3) + " kilometers.");
        Console.WriteLine("20 meters is equal to " + ConvertMetersToFeet(20) + " feet.");
        Console.WriteLine("50 feet is equal to " + ConvertFeetToMeters(50) + " meters.");
    }
}
