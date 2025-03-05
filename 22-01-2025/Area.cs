using System;

class Area
{
    static void Main(string[] args)
    {

        // Variable to take user input he base and height
        Console.Write("Enter the base of the triangle in centimeters: ");
        double baseCm = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the height of the triangle in centimeters: ");
       double heightCm = Convert.ToDouble(Console.ReadLine());

        // Calculating the area in square centimeters
        double areaCm = 0.5 * baseCm * heightCm;

        // Converting area to square inche
        double areaIn = areaCm * 0.155;

        //Results
        Console.WriteLine("The area of the triangle is " + areaCm + " square centimeters and " + areaIn + " square inches.");
    }
}
