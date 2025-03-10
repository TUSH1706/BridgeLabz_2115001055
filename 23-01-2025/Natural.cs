using System;

class Natural
{
    static void Main(string[] args)
    {
        //Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Checking if the number is a natural number
        if (number >= 0)
        {
            // Calculate the sum of n natural numbers
            int sum = number * (number + 1) / 2;

            //result
            Console.WriteLine("The sum of" + number+ " natural numbers is" +sum);
        }
        else
        {
           
            Console.WriteLine("The number" +number + " is not a natural number");
        }
    }
}
