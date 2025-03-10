using System;

class Height{
    static void Main(string[] args)
    {

        // Variable to take the user to input their height in centimeters
        Console.Write("Enter your height in centimeters: ");
       double heightCm = Convert.ToDouble(Console.ReadLine());  // Read the input and convert to double

        // Converting centimeters to inches (1 inch = 2.54 cm)
        double heightInches = heightCm / 2.54;

        // Converting inches to feet (1 foot = 12 inches)
        int feet = (int)(heightInches / 12);
        int inches = (int)(heightInches % 12);

        // Result
        Console.WriteLine("Your Height in cm is " + heightCm + " while in feet is " + feet + " and inches is " + inches);
    }
}
