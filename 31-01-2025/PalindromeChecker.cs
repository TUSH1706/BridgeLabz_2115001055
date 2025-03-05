using System;

class PalindromeChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string to check if it's a palindrome: ");
        string input = GetUserInput();
        bool isPalindrome = IsPalindrome(input);
        DisplayResult(input, isPalindrome);
    }
    static string GetUserInput()
    {
        string input = Console.ReadLine().Trim().ToLower();
        return new string(Array.FindAll(input.ToCharArray(), char.IsLetterOrDigit)); // Remove non-alphanumeric characters
    }
    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            
            left++;
            right--;
        }
        return true;
    }
    static void DisplayResult(string original, bool isPalindrome)
    {
        if (isPalindrome)
            Console.WriteLine($"\"{original}\" is a palindrome.");
        else
            Console.WriteLine($"\"{original}\" is not a palindrome.");
    }
}
