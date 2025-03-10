using System;

class TripDetails
{
    static void Main(string[] args)
    {

        //Variables to user input for name and cities
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter the name of the city he started: ");
        string fromCity = Console.ReadLine();
        
        Console.Write("Enter the name of the city he passedvia: ");
        string viaCity = Console.ReadLine();
        
        Console.Write("Enter the name of final destination city: ");
        string toCity = Console.ReadLine();

        // Variable to input for distances in miles
        Console.Write("Enter the distance from {0} to {1} (in miles): ", fromCity, viaCity);
       double fromToVia = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the distance from {0} to {1} (in miles): ", viaCity, toCity);
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Take user input for the time taken for the journey
        Console.Write("Enter the time taken for the entire journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculating the total distance
        double totalDistance = fromToVia + viaToFinalCity;

        //Results
        Console.WriteLine("\nThe results of the trip are:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Start City: " + fromCity);
        Console.WriteLine("Via City: " + viaCity);
        Console.WriteLine("Destination City: " + toCity);
        Console.WriteLine("Total Distance: " + totalDistance + " miles");
        Console.WriteLine("Time Taken: " + timeTaken + " hours");
        
        
    }
}
