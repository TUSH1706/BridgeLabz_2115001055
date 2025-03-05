using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicates
{
    public static void Main()
    {
        Console.WriteLine("Enter the string:");
        string input= Console.ReadLine();
        string result= RemoveDuplicateCharacters(input);
        Console.WriteLine("String after removing duplicates: " + result);
    }

    static string RemoveDuplicateCharacters(string input)
    {
        StringBuilder sb= new StringBuilder();
        HashSet<char> seen= new HashSet<char>();
        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
