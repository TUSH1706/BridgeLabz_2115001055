using System;

class SumOfNaturalNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("The entered number is not a natural number. Exiting the program.");
            return;
        }
        int sumRecursive = SumUsingRecursion(n);
        int sumFormula = SumUsingFormula(n);

        // Print the results
        Console.WriteLine("Sum of first " + n + " natural numbers using recursion: " + sumRecursive);
        Console.WriteLine("Sum of first " + n + " natural numbers using formula: " + sumFormula);

        if (sumRecursive == sumFormula)
        {
            Console.WriteLine("The results from both methods match. The computation is correct.");
        }
        else
        {
            Console.WriteLine("The results from both methods do not match. Check the logic.");
        }
    }
    static int SumUsingRecursion(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n + SumUsingRecursion(n - 1);
    }
    static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
