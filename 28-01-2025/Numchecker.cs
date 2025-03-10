using System;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
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

    // Method to reverse the digits array
    public static int[] ReverseArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0, j = digits.Length - 1; i < digits.Length; i++, j--)
        {
            reversed[j] = digits[i];
        }
        return reversed;
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }
        return true;
    }

    // Method to check if a number is a palindrome
    public static bool IsPalindrome(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[] reversed = ReverseArray(digits);
        return AreArraysEqual(digits, reversed);
    }

    // Method to check if a number is a duck number
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

    // Main method to demonstrate functionality
    public static void Main(string[] args)
    {
        int number = 121; // Example number

        Console.WriteLine("Number: " + number);

        // Count of digits
        int count = CountDigits(number);
        Console.WriteLine("Count of digits: " + count);

        // Digits array
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits array: " + string.Join(", ", digits));

        // Reverse array
        int[] reversedDigits = ReverseArray(digits);
        Console.WriteLine("Reversed digits array: " + string.Join(", ", reversedDigits));

        // Palindrome check
        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine("Is palindrome: " + isPalindrome);

        // Duck number check
        bool isDuckNumber = IsDuckNumber(number);
        Console.WriteLine("Is duck number: " + isDuckNumber);
    }
}
