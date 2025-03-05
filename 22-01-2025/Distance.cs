using System;

class Distance
{
    static void Main(string[] args)
    {
        //Variable for kilometers
        double km;

        //Variable user to input distance in kilometers
        Console.Write("Enter the distance in kilometers: ");
        km = Convert.ToDouble(Console.ReadLine());  // Read the input and convert to double

        // Converting kilometers to miles
        double miles = km / 1.6;

        // Result
        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}
