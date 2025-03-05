using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        //Get the month, day, and year from the user
        Console.Write("Enter month (1-12): ");
        int m = int.Parse(Console.ReadLine());  // Month
        
        Console.Write("Enter day: ");
        int d = int.Parse(Console.ReadLine());  // Day
        
        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());  // Year

        
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        // Output 
        Console.WriteLine("Day of the week: " + d0);
    }
}
