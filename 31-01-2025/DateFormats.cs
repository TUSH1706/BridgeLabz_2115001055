using System;

class DateFormat
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        // Display the date in different formats using standard date formats
        Console.WriteLine("Date in dd/MM/yyyy format: " + string.Format("{0:dd/MM/yyyy}", currentDate));
        Console.WriteLine("Date in yyyy-MM-dd format: " + string.Format("{0:yyyy-MM-dd}", currentDate));
        Console.WriteLine("Date in EEE, MMM dd, yyyy format: " + string.Format("{0:ddd, MMM dd, yyyy}", currentDate));
    }
}
