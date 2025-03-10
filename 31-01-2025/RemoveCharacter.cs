using System;

class Program
{
    static string RemoveCharacter(string input, char charToRemove)
    {
        string result = "";

        foreach (char ch in input)
        {
            if (ch != charToRemove)
            {
                result += ch;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadLine();
        string modifiedString = RemoveCharacter(input, charToRemove);

        Console.WriteLine("Modified String: " + modifiedString);
    }
}
