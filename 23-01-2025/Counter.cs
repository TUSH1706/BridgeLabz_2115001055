using System;

class RocketLaunch
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the countdown starting value
        Console.Write("Enter the countdown starting value: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;                 
        }

       
        Console.WriteLine("Liftoff!");
    }
}
