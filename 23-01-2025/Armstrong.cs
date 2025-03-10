using System;

class ArmstrongNumber
{
    static void Main(string[] args)
    {
        // Input: Get the number from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize variables
        int sum = 0;
        int originalNumber = number;


        while (number != 0)
        {
            
            int digit = number % 10;

            
            sum += digit * digit * digit;

            
            number /= 10;
        }

        /
        if (sum == originalNumber)
        {
            Console.WriteLine(originalNumber + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not an Armstrong number.");
        }
    }
}
