using System;

class Factorial
    static void Main(string[] args)
    {
        int number = GetInput();
        long factorial = CalculateFactorial(number);
		DisplayOutput(number, factorial);
    }
    static int GetInput()
    {
        Console.Write("Enter a non-negative integer: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            Console.Write("Enter a non-negative integer: ");
        }
        return number;
    }
    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * CalculateFactorial(n - 1);
    }
    static void DisplayOutput(int number, long factorial)
    {
        Console.WriteLine($"The factorial of {number} is {factorial}.");
    }
}