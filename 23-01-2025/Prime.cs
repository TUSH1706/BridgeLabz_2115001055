using System;

class Prime
{
    static void Main(string [] args)
    {
        Console.Write("Enter a number to check if it's prime: ");
        int number = int.Parse(Console.ReadLine());
        
        bool isPrime = CheckPrime(number);
        
        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
    
    static bool CheckPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
}
