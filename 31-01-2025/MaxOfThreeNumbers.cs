xusing System;

class MaxOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three integers:");
        int num1 = GetIntegerInput("Enter first number: ");
        int num2 = GetIntegerInput("Enter second number: ");
        int num3 = GetIntegerInput("Enter third number: ");
        int maxNumber = FindMaximum(num1, num2, num3);

        // Display result
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
    static int GetIntegerInput(string message)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }
    static int FindMaximum(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
}
