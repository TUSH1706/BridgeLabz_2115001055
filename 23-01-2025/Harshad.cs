using System;

class HarshadNumber
{
    static void Main(string[] args)
    {
        // Get the integer number from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Variable to store the sum of digits
        int sum = 0;
        int originalNumber = number;
        while (number != 0)
        {
			int digit = number % 10;
            sum += digit;number /= 10;
        }

        // Check if the original number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            Console.WriteLine(originalNumber + " is a Harshad Number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not a Harshad Number.");
        }
    }
}
