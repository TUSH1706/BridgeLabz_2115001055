using System;

class LeapYear
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a year (>= 1582):");
        int year;
        
        if (!int.TryParse(Console.ReadLine(), out year) || year < 1582)
        {
            Console.WriteLine("Invalid input. Please enter a year >= 1582.");
            return;
        }
        
        if (IsLeapYear(year))
        {
            Console.WriteLine(year + "is a leap year.");
        }
        else
        {
            Console.WriteLine(year +  "is not a leap year.");
        }
    }

    static bool IsLeapYear(int year)
    {
        if (year >= 1582)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
        }
        
        return false;
    }
}
