using System;

class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] GetFactors(int number)
    {
        int count = 0;

        // Count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        // Populate the factors array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int GreatestFactor(int[] factors)
    {
        return factors[factors.Length - 2]; // Second last element is the greatest proper factor
    }

    // Method to find the sum of factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of factors
    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of factors
    public static double ProductOfCubesOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int[] factors = GetFactors(number);
        int sumOfProperDivisors = SumOfFactors(factors) - number;
        return sumOfProperDivisors == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int[] factors = GetFactors(number);
        int sumOfProperDivisors = SumOfFactors(factors) - number;
        return sumOfProperDivisors > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int[] factors = GetFactors(number);
        int sumOfProperDivisors = SumOfFactors(factors) - number;
        return sumOfProperDivisors < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int sumOfFactorials = 0;
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sumOfFactorials += Factorial(digit);
            temp /= 10;
        }

        return sumOfFactorials == number;
    }

    // Helper method to calculate factorial
    private static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    // Main method to demonstrate functionality
    public static void Main(string[] args)
    {
        int number = 28; // Example number

        Console.WriteLine("Number: " + number);

        // Factors
        int[] factors = GetFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        // Greatest factor
        int greatestFactor = GreatestFactor(factors);
        Console.WriteLine("Greatest proper factor: " + greatestFactor);

        // Sum of factors
        int sumOfFactors = SumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sumOfFactors);

        // Product of factors
        int productOfFactors = ProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + productOfFactors);

        // Product of cubes of factors
        double productOfCubes = ProductOfCubesOfFactors(factors);
        Console.WriteLine("Product of cubes of factors: " + productOfCubes);

        // Perfect number check
        bool isPerfect = IsPerfectNumber(number);
        Console.WriteLine("Is perfect number: " + isPerfect);

        // Abundant number check
        bool isAbundant = IsAbundantNumber(number);
        Console.WriteLine("Is abundant number: " + isAbundant);

        // Deficient number check
        bool isDeficient = IsDeficientNumber(number);
        Console.WriteLine("Is deficient number: " + isDeficient);

        // Strong number check
        bool isStrong = IsStrongNumber(number);
        Console.WriteLine("Is strong number: " + isStrong);
    }
}
