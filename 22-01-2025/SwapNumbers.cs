using System;

class SwapNumbers
{
    static void Main(string[] args)
    {
        // Take user input for number1 and number2
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Swapping the numbers
        double temp = number1;
        number1 = number2;
        number2 = temp;

        // Result
        Console.WriteLine("The swapped numbers are: " + number1 + " and " + number2);
    }
}
