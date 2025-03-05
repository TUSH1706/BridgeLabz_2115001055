using System;

class FibonacciGenerator
{
    static void Main()
    {
        Console.Write("Enter the number of terms for the Fibonacci sequence: ");
        int terms = GetPositiveIntegerInput();
        GenerateFibonacci(terms);
    }
    static int GetPositiveIntegerInput()
    {
        int num;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out num) && num > 0)
            {
                return num;
            }
            Console.Write("Invalid input! Please enter a positive integer: ");
        }
    }
    static void GenerateFibonacci(int n)
    {
        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci sequence:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }
}
