using System;

class SubString
{
    static int CountSubstringOccurrences(string mainString, string substring)
    {
        int count = 0;
        int mainStringLength = mainString.Length;
        int substringLength = substring.Length;
        for (int i = 0; i <= mainStringLength - substringLength; i++)
        {
            bool match = true;
            for (int j = 0; j < substringLength; j++)
            {
                if (mainString[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                count++;
            }
        }

        return count;
    }
    static void Main()
    {
        Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();
        Console.Write("Enter the substring: ");
        string substring = Console.ReadLine();
        int occurrences = CountSubstringOccurrences(mainString, substring);
        Console.WriteLine($"The substring '{substring}' occurs {occurrences} time(s) in the string.");
    }
}
