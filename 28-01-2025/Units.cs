using System;

public static class Units
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5.0 / 9.0;
        return fahrenheit2celsius;
    }

    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9.0 / 5.0) + 32;
        return celsius2fahrenheit;
    }

    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    // Testing the methods
    public static void Main()
    {
        Console.WriteLine("100 Fahrenheit is equal to " + ConvertFahrenheitToCelsius(100) + " Celsius.");
        Console.WriteLine("37 Celsius is equal to " + ConvertCelsiusToFahrenheit(37) + " Fahrenheit.");
        Console.WriteLine("150 pounds is equal to " + ConvertPoundsToKilograms(150) + " kilograms.");
        Console.WriteLine("70 kilograms is equal to " + ConvertKilogramsToPounds(70) + " pounds.");
        Console.WriteLine("10 gallons is equal to " + ConvertGallonsToLiters(10) + " liters.");
        Console.WriteLine("5 liters is equal to " + ConvertLitersToGallons(5) + " gallons.");
    }
}
