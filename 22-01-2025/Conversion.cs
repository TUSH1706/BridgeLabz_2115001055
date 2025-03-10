using System;

class Conversion
{
    static void Main(string[] args)
    {
        // Variable for distance in kilometers
        double distanceInKm = 10.8;

        // Variable for conversion factor
        double kmToMiles = 1.6;

        // Variable to convert kilometers to miles
        double distanceInMiles = distanceInKm / kmToMiles;

        //Result
        Console.WriteLine("The distance " + distanceInKm + " km in miles is " + distanceInMiles);
    }
}
