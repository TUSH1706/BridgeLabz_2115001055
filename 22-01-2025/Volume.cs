using System;

class Volume
{
    static void Main(string[] args)
    {
        // Variable for given radius of Earth in kilometers
        double radiusKm = 6378;

        // Calculating the volume of Earth in cubic kilometers
        double volumeKm3 = (4.0 / 3.0) *Math.PI * Math.Pow(radiusKm, 3);

        // Conversion factor: 1 km^3 = 0.239913 cubic miles
        double volumeMiles3 = volumeKm3 * 0.239913;

        // Results
        Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm3 + " and cubic miles is " + volumeMiles3);
    }
}
