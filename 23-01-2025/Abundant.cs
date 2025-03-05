using System;

class AbundantNumber
{
    static void Main(string[] args)
    {
        // Input: Get the integer number from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Variable to store the sum of divisors
        int sum = 0;

       
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)  
            {
                sum += i;  
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            Console.WriteLine(number + " is an Abundant Number.");
        }
        else
        {
            Console.WriteLine(number + " is not an Abundant Number.");
        }
    }
}
