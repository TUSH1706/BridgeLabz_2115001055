using System;

class DateCompare
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        DateTime firstDate;
        while (!DateTime.TryParse(Console.ReadLine(), out firstDate))
        {
            Console.Write("Invalid date format! Please enter again (yyyy-MM-dd): ");
        }
        Console.Write("Enter the second date (yyyy-MM-dd): ");
        DateTime secondDate;

        while (!DateTime.TryParse(Console.ReadLine(), out secondDate))
        {
            Console.Write("Invalid date format! Please enter again (yyyy-MM-dd): ");
        }
        int comparisonResult = DateTime.Compare(firstDate, secondDate);
        if (comparisonResult < 0)
        {
            Console.WriteLine("The first date is before the second date.");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("The two dates are the same.");
        }
    }
}
