using System;
using System.Collections.Generic;

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
    public static bool IsDuckNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        foreach (int digit in digits)
        {
            if (digit == 0)
                return true;
        }
        return false;
    }
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int numDigits = digits.Length;
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, numDigits);
        }
        return sum == number;
    }
    public static (int largest, int secondLargest) FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
        return (largest, secondLargest);
    }
    public static (int smallest, int secondSmallest) FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }
        return (smallest, secondSmallest);
    }
    public static void Main(string[] args)
    {
        int number = 153;

        Console.WriteLine("Number: " + number);

        // Count of digits
        int count = CountDigits(number);
        Console.WriteLine("Count of digits: " + count);
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits array: " + string.Join(", ", digits));
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine("Is duck number: " + isDuck);

        bool isArmstrong = IsArmstrongNumber(number);
        Console.WriteLine("Is Armstrong number: " + isArmstrong);
        var (largest, secondLargest) = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
        var (smallest, secondSmallest) = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest digit: " + smallest);
        Console.WriteLine("Second smallest digit: " + secondSmallest);
    }
}
