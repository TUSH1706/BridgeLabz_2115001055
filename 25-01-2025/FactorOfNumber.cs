using System;

class FactorsOfNumber
{
    static void Main(string [] args)
    {\
        Console.Write("Enter a number to find its factors: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive integer.");
            return;
        }
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) // Check if i is a factor
            {
                if (index == maxFactor)
                {
                    maxFactor *= 2; // Double the array size
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }

                factors[index++] = i; // Add the factor to the array
            }
        }
        Console.WriteLine($"\nFactors of {number}:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine(); // For cleaner output
    }
}
