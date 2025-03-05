using System;

class Vowels
{
    static void CountVowelsAndConsonants(string input)
    {
        int vowelCount = 0, consonantCount = 0;
       
        input = input.ToLower();
        
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".Contains(c)) 
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }
        
        Console.WriteLine("Vowels: " + vowelCount);
        Console.WriteLine("Consonants: " + consonantCount);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        CountVowelsAndConsonants(input);
    }
}
