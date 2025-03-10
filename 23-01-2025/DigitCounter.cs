using System;

class DigitCounter
{
    static void Main(string[] args)
    {
        // Input: Get the integer from the user
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize the count variable to 0
        int count = 0;
		while (number != 0)
        {
            // Remove the last digit from the number
            number /= 10;
            count++;
        }

        // Display the result
        Console.WriteLine("The number of digits is: " + count);
    }
}
