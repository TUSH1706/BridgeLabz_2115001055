using System;

class CalendarGenerator
{
    // Method to get the name of the month
    public static string GetMonthName(int month)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Method to get the number of days in a month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year))
            return 29;
        return days[month - 1];
    }

    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get the first day of the month
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int d = 1; // First day of the month
        int y = year - (14 - month) / 12;
        int x = y + y / 4 - y / 100 + y / 400;
        int m = month + 12 * ((14 - month) / 12) - 2;
        return (d + x + (31 * m) / 12) % 7;
    }

    // Method to display the calendar
    public static void DisplayCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        Console.WriteLine($"\n     {monthName} {year}");
        Console.WriteLine(" Su Mo Tu We Th Fr Sa");

        // Print initial spaces for the first day
        for (int i = 0; i < firstDay; i++)
            Console.Write("   ");

        // Print days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3}");
            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void MainCalendar()
    {
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}
