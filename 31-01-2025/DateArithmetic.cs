using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate;
        
        while (!DateTime.TryParse(Console.ReadLine(), out inputDate))
        {
            Console.Write("Invalid date format! Please enter again (yyyy-MM-dd): ");
        }
        DateTime newDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);                           
		DateTime finalDate = newDate.AddDays(-21); // Subtract 3 weeks (21 days)
        Console.WriteLine("\nOriginal Date: " + inputDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("After Adding 7 Days, 1 Month, 2 Years: " + newDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("After Subtracting 3 Weeks: " + finalDate.ToString("yyyy-MM-dd"));
    }
}
