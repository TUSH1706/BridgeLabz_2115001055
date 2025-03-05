using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the full path of the text file: ");
        string filePath = Console.ReadLine();
        Console.Write("Enter the word to count: ");
        string searchWord = Console.ReadLine();
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Please enter a valid file path.");
            return;
        }
        try
        {
            int wordCount = 0;
            string line;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    int i = 0;                    
                    while (i < line.Length)
                    {
                        char[] wordArray = new char[searchWord.Length];
                        int j = 0;
                        while (i < line.Length && j < searchWord.Length && CharMatch(line[i], searchWord[j]))
                        {
                            wordArray[j] = line[i];
                            i++;
                            j++;
                        }
                        if (j == searchWord.Length && (i == line.Length || !IsAlphabet(line[i])))
                        {
                            wordCount++;
                        }
                        while (i < line.Length && !IsAlphabet(line[i]))
                        {
                            i++;
                        }
                    }
                }
            }

            Console.WriteLine("The word " +searchWord + " appears " +wordCount + " times in the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }
    }
    static bool CharMatch(char a, char b)
    {
        return ToLower(a) == ToLower(b);
    }
    static char ToLower(char c)
    {
        if (c >= 'A' && c <= 'Z')
            return (char)(c + 32);
        return c;
    }
    static bool IsAlphabet(char c)
    {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }
}
