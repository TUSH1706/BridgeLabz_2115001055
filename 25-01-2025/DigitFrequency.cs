using System;

class DigitFrequency
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        if (!long.TryParse(input, out _))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        int[] frequency = new int[10];
        foreach (char digitChar in input)
        {
            if (char.IsDigit(digitChar))
            {
                int digit = digitChar - '0';
                frequency[digit]++;
            }
        }

        
        Console.WriteLine("\nFrequency of digits:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digit {i}: {frequency[i]}");
        }
    }
}
