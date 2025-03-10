using System;

class MultiplesFinder
{
    static void Main(string[] args)
    {
        // Input: Get the number from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Loop backward from 100 to 1
        Console.WriteLine("Multiples of " + number + " below 100 are:");

        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)            {
                Console.WriteLine(i);
            }
        }
    }
}
