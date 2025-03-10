using System;

class Perimeter
{
    static void Main(string[] args)
    {

        // Variable to take user input the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
       double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculating the side length of the square
        double side = perimeter / 4;

        // Result
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
