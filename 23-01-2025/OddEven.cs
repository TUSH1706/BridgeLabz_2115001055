using System;

class OddEven
{
    static void Main(string[] args)
    {
        //Prompt the user to enter a number
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        
        if (number < 1)
        {
            Console.WriteLine("The number must be a natural number (greater than or equal to 1).");
        }
        else
        {
            Console.WriteLine("Odd and even numbers between 1 and " + number + ":");

            // Using a for loop to iterate from 1 to the number
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is an even number.");
                }
                else
                {
                    Console.WriteLine(i + " is an odd number.");
                }
            }
        }
    }
}
