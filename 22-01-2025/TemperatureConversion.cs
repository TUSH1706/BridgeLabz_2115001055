using System;

class TemperatureConversion
{
    static void Main(string[] args)
    {

        // Variable to take user input for Celsius temperature
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Converting Celsius to Fahrenheit using the formula
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        //result
        Console.WriteLine(celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
    }
}
