using System;

class TimeZoneInfo
{
    static void Main(string[] args)
    {
		DateTime utcNow = DateTime.UtcNow; 

       DateTime gmtTime = utcNow; 
        DateTime istTime = utcNow.AddHours(5).AddMinutes(30); 
        DateTime pstTime = utcNow.AddHours(-8);
        // Display the times
        Console.WriteLine("Current Time in Different Time Zones:");
        Console.WriteLine("UTC Time: " +utcNow);
        Console.WriteLine("GMT Time: "+gmtTime);
        Console.WriteLine("IST Time: "+istTime);
        Console.WriteLine("PST Time: "+pstTime);
    }
}
