using System;

class TriangularParkRun
{
    static void Main(string[] args)
    {

        //Vairable to take user input for the sides of the triangle
        Console.Write("Enter the length of the first side (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the length of the second side (in meters): ");
        doubleside2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the length of the third side (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculating  the perimeter of the triangular park
        double perimeter = side1 + side2 + side3;

        // Converting the required distance to meters
        double totalDistance = 5000;

        // Calculating the number of rounds needed
        double rounds = totalDistance / perimeter;

        // Result
        Console.WriteLine("The total number of rounds the athlete will run is " + Math.Ceiling(rounds) + " to complete 5 km.");
    }
}
