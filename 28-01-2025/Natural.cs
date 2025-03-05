using System;

class NaturalNumberSum
{
    // Method to calculate the sum of n natural numbers using a loop
    public static int SumOfNaturalNumbers(int n)
    {
        int sum = 0;
        
        // Loop to calculate the sum
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        
        return sum;
    }

    static void Main(string[] args)
    {
        // Get input for the number n
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Validate input
        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Calculate the sum of first n natural numbers
        int sum = SumOfNaturalNumbers(n);

        // Display the result
        Console.WriteLine("The sum of the first " + n + " natural numbers is: " + sum);
    }
}
