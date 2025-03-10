using System;

class ArrayAnalysis
{
    static void Main(string [] args)
    {
        int[] numbers = new int[5];]
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter number " + (i + 1) + ": ");
            }
        }
        Console.WriteLine("\nNumber Analysis:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0) // Positive numbers
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("Number " + numbers[i] + " is positive and even.");
                }
                else
                {
                    Console.WriteLine("Number " + numbers[i] + " is positive and odd.");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine("Number " + numbers[i] + " is negative.");
            }
            else
            {
                Console.WriteLine("Number " + numbers[i] + " is zero.");
            }
        }
        Console.WriteLine("\nComparison of the first and last elements:");
        if (numbers[0] > numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is greater than the last element (" + numbers[numbers.Length - 1] + ").");
        }
        else if (numbers[0] < numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is less than the last element (" + numbers[numbers.Length - 1] + ").");
        }
        else
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is equal to the last element (" + numbers[numbers.Length - 1] + ").");
        }
    }
}
