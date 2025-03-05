using System;

class LeapYear
{
    static void Main(string[] args)
    {
        //Prompt the user to enter a year
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        
        if (year >= 1582)
        {
            
            if (year % 4 == 0)
            {
                
                if (year % 100 == 0)
                {
                    // Check if the year is divisible by 400
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a Leap Year.");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a Leap Year.");
                    }
                }
                else
                {
                    Console.WriteLine(year + " is a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Year must be greater than or equal to 1582.");
        }
    }
}
