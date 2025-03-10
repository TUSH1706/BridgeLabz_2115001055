using System;

class Age
{
    static void Main(string[] args)
    {
        // Creating variable for birth year and current year
        int birthYear = 2000;
        int currentYear = 2024;

        // Calculating the age
        int age = currentYear - birthYear;

        // result
        Console.WriteLine("Harry's age in 2024 is " + age);
    }
}
