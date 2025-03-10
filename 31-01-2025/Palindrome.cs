using System;

class Palindrome
{
    static bool IsPalindrome(string input)
    {
        int start = 0;
        int end = input.Length - 1;

        while (start < end)
        {
            // Skip non-alphabetic characters and move pointers inward
            if (!char.IsLetterOrDigit(input[start]))
            {
                start++;
            }
            else if (!char.IsLetterOrDigit(input[end]))
            {
                end--;
            }
            else
            {
                if (char.ToLower(input[start]) != char.ToLower(input[end]))
                {
                    return false;
                }
                start++;
                end--;
            }
        }

        return true;
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Check if the string is a palindrome and display the result
        if (IsPalindrome(input))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}
