using System;

class Factors
{
    
    static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }
        
        return factors;
    }
    
    static void DisplayFactors(int[] factors)
    {
        Console.WriteLine("Factors:");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();
    }
    
    static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }
    
    static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }
    
    static double SumOfSquareOfFactors(int[] factors)
    {
        double sum = 0;
        foreach (int factor in factors)
        {
            sum += Math.Pow(factor, 2);
        }
        return sum;
    }
	static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        
        int[] factors = FindFactors(number);
        DisplayFactors(factors);
        
        int sumOfFactors = SumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sumOfFactors);
        
        int productOfFactors = ProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + productOfFactors);
        
        double sumOfSquareOfFactors = SumOfSquareOfFactors(factors);
        Console.WriteLine("Sum of square of factors: " + sumOfSquareOfFactors);
    }
}
