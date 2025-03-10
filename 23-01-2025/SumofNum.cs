using System;

class SumNumbers
{
    static void Main(string[] args)
    {
        double total = 0.0;
        double userInput;

        // Prompt the user to enter numbers to sum
        Console.WriteLine("Enter numbers to sum. Enter 0 or a negative number to stop:");

        
        while (true)
        {
            Console.Write("Enter a number: ");
            userInput = Convert.ToDouble(Console.ReadLine());

          
            if (userInput <= 0)
            {
                break;
            }

            
            total += userInput;
        }

      
        Console.WriteLine("The total sum is: " + total);
    }
}
