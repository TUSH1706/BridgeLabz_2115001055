using System;

class NumberChecker
{
    // Method to check if a number is a prime number
    public static bool IsPrimeNumber(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;

        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }

        return sumOfDigits == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpyNumber(int number)
    {
        int sumOfDigits = 0, productOfDigits = 1;

        while (number > 0)
        {
            int digit = number % 10;
            sumOfDigits += digit;
            productOfDigits *= digit;
            number /= 10;
        }

        return sumOfDigits == productOfDigits;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }

    // Main method to demonstrate functionality
    public static void Main(string[] args)
    {
        int number = 7; // Example number

        Console.WriteLine("Number: " + number);

        // Prime number check
        bool isPrime = IsPrimeNumber(number);
        Console.WriteLine("Is prime number: " + isPrime);

        // Neon number check
        bool isNeon = IsNeonNumber(number);
        Console.WriteLine("Is neon number: " + isNeon);

        // Spy number check
        bool isSpy = IsSpyNumber(number);
        Console.WriteLine("Is spy number: " + isSpy);

        // Automorphic number check
        bool isAutomorphic = IsAutomorphicNumber(number);
        Console.WriteLine("Is automorphic number: " + isAutomorphic);

        // Buzz number check
        bool isBuzz = IsBuzzNumber(number);
        Console.WriteLine("Is buzz number: " + isBuzz);
    }
}
