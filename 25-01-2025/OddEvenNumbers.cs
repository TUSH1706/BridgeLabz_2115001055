using System;

class OddEvenNumbers
{
    static void Main()
    {
        Console.Write("Enter a natural number (greater than 0): ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Error: Please enter a valid natural number greater than 0.");
            return;
        }
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                // Even number
                evenNumbers[evenIndex++] = i;
            }
            else
            {
                // Odd number
                oddNumbers[oddIndex++] = i;
            }
        }
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
        Console.WriteLine(); // For cleaner output
    }
}
