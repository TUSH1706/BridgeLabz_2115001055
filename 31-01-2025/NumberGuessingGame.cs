using System;

class NumberGuessingGame
{
    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("I will try to guess it!");
        Console.WriteLine("Respond with 'high', 'low', or 'correct'.");

        int low = 1, high = 100;
        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        {
            int guess = (low + high) / 2;
            Console.WriteLine("Is your number " + guess + "? (Respond with 'high', 'low', or 'correct')");

            string response = Console.ReadLine().Trim().ToLower();

            if (response == "correct")
            {
                Console.WriteLine("Yay! I guessed your number " + guess + " correctly!");
                guessedCorrectly = true;
            }
            else if (response == "high")
            {
                high = guess - 1;
            }
            else if (response == "low")
            {
                low = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid response! Please enter 'high', 'low', or 'correct'.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
