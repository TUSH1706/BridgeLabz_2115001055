using System;

class WeightConverter
{
    static void Main(string[] args)
    {
        // Variable to take user input for weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Converting weight to kilograms
        double weightInKg = weightInPounds / 2.2;

        // Results
        Console.WriteLine("The weight of the person in pounds is " + weightInPounds + " and in kg is " + weightInKg);
    }
}
