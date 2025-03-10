using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Enter a number to generate its multiplication table: ");
        }
        int[] multiplicationTable = new int[10];
        for (int i = 0; i < multiplicationTable.Length; i++)
        {
            multiplicationTable[i] = number * (i + 1);
        }
        Console.WriteLine("\nMultiplication Table of " + number + ":");
        for (int i = 0; i < multiplicationTable.Length; i++)
        {
            Console.WriteLine(number + " * " + (i + 1) + " = " + multiplicationTable[i]);
        }
    }
}
