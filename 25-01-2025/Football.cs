using System;

class Football
{
    static void Main(string [] args)
    {
        double[] heights = new double[11];
        double sum = 0.0;

        Console.WriteLine("Enter the heights of 11 football players:");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter height of player " + (i + 1) + ": ");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                Console.Write("Enter height of player " + (i + 1) + ": ");
            }

            heights[i] = height;
            sum += height; // Add the height to the sum
        }
        double mean = sum / heights.Length;
        Console.WriteLine("\nThe mean height of the football team is: " + mean.ToString("F2") + " units.");
    }
}
