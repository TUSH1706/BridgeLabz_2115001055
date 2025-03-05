using System;

class NumberChecker
{
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }
    public static int[] GetDigitsArray(int number)
    {
        string numStr = number.ToString();
        int[] digits = new int[numStr.Length];
        for (int i = 0; i < numStr.Length; i++)
        {
            digits[i] = numStr[i] - '0';
        }
        return digits;
    }
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }
    public static int SumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }
    public static bool IsHarshadNumber(int number, int sumOfDigits)
    {
        return number % sumOfDigits == 0;
    }
    public static int[,] GetDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2]; 
       
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
        }
        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }
    public static void Main(string[] args)
    {
        int number = 21;

        Console.WriteLine("Number: " + number);
        int count = CountDigits(number);
        Console.WriteLine("Count of digits: " + count);
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits array: " + string.Join(", ", digits));
        int sumOfDigits = SumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sumOfDigits);
        int sumOfSquares = SumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);
        bool isHarshad = IsHarshadNumber(number, sumOfDigits);
        Console.WriteLine("Is Harshad number: " + isHarshad);
        int[,] frequency = GetDigitFrequency(digits);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine($"Digit {frequency[i, 0]}: {frequency[i, 1]} times");
            }
        }
    }
}
