using System;

class Fizz
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
        else
        {
            int i = 1;
            while (i <= number)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);

                i++;
            }
        }
    }
}
