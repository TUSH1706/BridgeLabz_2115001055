using System;

class Reverse
{
    static void Main()
    {
        // Input the number from the user
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        // Creating an array to store the digits
        int[] digits = new int[10];
        int index = 0;
        while (num != 0)
        {
            digits[index] = num % 10;
            num /= 10;  
            index++;
        }
        // Display the reversed number
        Console.Write("Reversed number: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}
