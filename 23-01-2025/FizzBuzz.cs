using System;

class FizzBuzz
{
    static void Main(string [] args)
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        
        if (number <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
        else
        {
            
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
