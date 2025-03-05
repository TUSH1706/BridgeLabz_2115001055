using System;

class Divisiblity
{
    static void Main(string [] args)
    {
        // Prompt the user for input
        Console.Write("Enter a number: ");
        
        // Reading the input and convert to an integer
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Checking divisibility and display the result
        if (number % 5 == 0)
        {
            Console.WriteLine("Is the number" +number+ " divisible by 5? Yes");
        }
        else
        {
            Console.WriteLine("Is the number " +number + " divisible by 5? No");
        }
    }
}
