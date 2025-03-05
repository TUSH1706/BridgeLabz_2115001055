using System;

public class RandomNumber
{
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000); 
        }
        return randomNumbers;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        double min = numbers[0];
        double max = numbers[0];
        
        foreach (int number in numbers)
        {
            sum += number;
            min = Math.Min(min, number);
            max = Math.Max(max, number);
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }

    public static void Main()
    {
        int size = 5;
        int[] randomNumbers = Generate4DigitRandomArray(size);
        
        Console.WriteLine("Generated 4-digit random numbers: ");
        foreach (int number in randomNumbers)
        {
            Console.WriteLine(number);
        }

        double[] results = FindAverageMinMax(randomNumbers);
        double average = results[0];
        double min = results[1];
        double max = results[2];
        
        Console.WriteLine("Average:" +average);
        Console.WriteLine("Minimum:" +min);
        Console.WriteLine("Maximum:" +max);
    }
}
