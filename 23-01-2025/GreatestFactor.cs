using System;

class GreatestFactor
{
    static void Main(string[] args)
    {
        // Input: Get an integer from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Variable to store the greatest factor
        int greatestFactor = 1;

       
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        // Display the greatest factor
        Console.WriteLine("The greatest factor of " + number + " (besides itself) is: " + greatestFactor);
    }
}
