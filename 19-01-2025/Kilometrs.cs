using System;

class Kilometers
{
    static void Main(string[] args)
    {
       
        Console.Write("Enter the distance in kilometers: ");
        int kilometers = int.Parse(Console.ReadLine());

      
        double miles = kilometers * 0.621371;

    
        Console.WriteLine("{0} kilometers is equal to {1} miles.", kilometers, miles);
    }
}
