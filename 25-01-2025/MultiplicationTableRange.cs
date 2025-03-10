using System;

class MultiplicationTableRange
{
    static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table from 6 to 9: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Enter a number to generate its multiplication table from 6 to 9: ");
        }
        int[] multiplicationResult = new int[4];
        for (int i = 0; i < multiplicationResult.Length; i++)
        {
            multiplicationResult[i] = number * (i + 6); // Start from 6
        }
        Console.WriteLine("\nMultiplication Table of " + number + " from 6 to 9:");
        for (int i = 0; i < multiplicationResult.Length; i++)
        {
            Console.WriteLine(number + " * " + (i + 6) + " = " + multiplicationResult[i]);
        }
    }
}
