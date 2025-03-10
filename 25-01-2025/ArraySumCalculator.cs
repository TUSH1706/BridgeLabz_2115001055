using System;

class ArraySumCalculator
{
    static void Main(string [] args)
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter up to 10 numbers. Enter 0 or a negative number to stop.");
        while (true)
        {
            Console.Write("Enter number " + (index + 1) + ": ");
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter number " + (index + 1) + ": ");
            }
            if (input <= 0)
            {
                break;
            }
            numbers[index] = input;
            index++;
            if (index == 10)
            {
                break;
            }
        }
        Console.WriteLine("\nEntered Numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }
        Console.WriteLine("\nTotal of all numbers: " + total);
    }
}
