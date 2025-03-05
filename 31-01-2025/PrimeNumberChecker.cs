using System;

class PrimeNumberChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it's prime: ");
        int number = GetIntegerInput();
        bool isPrime = IsPrime(number);
        if (isPrime)
            Console.WriteLine(number + " is a prime number.");
        else
            Console.WriteLine(number + " is not a prime number.");
    }
    static int GetIntegerInput()
    {
        int num;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out num) && num >= 0)
            {
                return num;
            }
            Console.Write("Invalid input! Please enter a non-negative integer: ");
        }
    }
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;
        if (num == 2 || num == 3)
            return true;
        if (num % 2 == 0)
            return false;

        for (int i = 3; i * i <= num; i += 2) 
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
