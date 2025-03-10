using System;

class Calculator
{
    static void Main(string[] args)
    {
        // Declare two double variables for the operands and a string for the operator
        double first, second;
        string op;

        // Get input for the first operand, second operand, and operator
        Console.Write("Enter the first number: ");
        first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operator (+, -, *, /): ");
        op = Console.ReadLine();

        Console.Write("Enter the second number: ");
        second = Convert.ToDouble(Console.ReadLine());

        // Perform operations based on the operator using a switch...case statement
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;
            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;
            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;
            case "/":
                // Handle division by zero
                if (second == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine("Result: " + (first / second));
                }
                break;
            default:
                Console.WriteLine("Invalid Operator.");
                break;
        }
    }
}
