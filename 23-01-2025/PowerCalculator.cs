using System;

class PowerCalculator
{
    static void Main(string[] args)
    {
        // Input: Get integer inputs for number and power
        Console.Write("Enter the base number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        // Variable to store the result, initialized to 1
        int result = 1;

        /
        for (int i = 1; i <= power; i++)
        {
            result *= number;  
        }

        // result
        Console.WriteLine(number + " raised to the power of " + power + " is: " + result);
    }
}
