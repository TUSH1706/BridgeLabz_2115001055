using System;

class Reverse
{
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        int start = 0;
        int end = charArray.Length - 1;
        while (start < end)
        {
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            start++;
            end--;
        }

        return new string(charArray);
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Reverse the string and display the result
        string reversedString = ReverseString(input);
        Console.WriteLine("Reversed string: " + reversedString);
    }
}
