using System;

class FactorialProgram
{
    static void Main(string[] args)
    {
        //Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            
            long factorial = 1;
            int counter = number;
            while (counter > 1)
            {
                factorial *= counter;
                counter--;
            }

            // Output the result
            Console.WriteLine("The factorial of " + number + " is: " + factorial);
        }
    }
}
