using System;

class TemperatureConversion
{
    static void Main(string[] args)
    {

        // Variable to take user input for Fahrenheit temperature
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Converting Fahrenheit to Celsius using the formula
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Result
        Console.WriteLine(fahrenheit + " Fahrenheit is " + celsiusResult + " Celsius");
    }
}
