using System;

class DuplicateRemove
{
 
    static string RemoveDuplicates(string input)
    {
        bool[] seen = new bool[256]; 
        string result = "";

        foreach (char c in input)
        {
            if (!seen[c]) 
            {
                result += c;
                seen[c] = true; 
            }
        }

        return result;
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Remove duplicates and display the result
        string modifiedString = RemoveDuplicates(input);
        Console.WriteLine("String after removing duplicates: " + modifiedString);
    }
}
