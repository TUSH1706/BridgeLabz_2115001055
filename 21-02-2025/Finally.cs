using System;

class Finally
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int result = num1 / num2;
            Console.WriteLine("Result: " +result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred:" + ex.Message);
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }
}