using System;

class BasicCalculator
{
    static void Main(string[] args)
    {
        //Variable to take user input for the first number
        Console.Write("Enter the first number: ");
        float number1 = float.Parse(Console.ReadLine());

        //Variable to take user inoutfor the second number
        Console.Write("Enter the second number: ");
        float number2 = float.Parse(Console.ReadLine());

        // arithmetic operations
        float addition = number1 + number2;
        float subtraction = number1 - number2;
        float multiplication = number1 * number2;
        float division = 0;

        // Checking for division by zero
        if (number2 != 0)
        {
            division = number1 / number2;
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }

        //Results
        Console.WriteLine("Results:");
        Console.WriteLine("Addition: " + number1 + " + " + number2 + " = " + addition);
        Console.WriteLine("Subtraction: " + number1 + " - " + number2 + " = " + subtraction);
        Console.WriteLine("Multiplication: " + number1 + " * " + number2 + " = " + multiplication);
        if (number2 != 0)
        {
            Console.WriteLine("Division: " + number1 + " / " + number2 + " = " + division);
        }

	}
}
