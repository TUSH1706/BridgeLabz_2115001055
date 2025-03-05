using System;

class LeapYear
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a year
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Single 'if' statement using logical operators
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}