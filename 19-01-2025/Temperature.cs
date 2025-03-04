using System;

class Temperature
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Celsius: ");
        int celsius = int.Parse(Console.ReadLine());
        int fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("The temperature in Fahrenheit is: {0}", fahrenheit);
    }
}
