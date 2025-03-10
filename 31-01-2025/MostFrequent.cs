using System;


class MostFrequent
{
    static char FindMostFrequentCharacter(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        char mostFrequentChar = '\0';
        int maxCount = 0;

        foreach (char ch in input)
        {
            if (charCount.ContainsKey(ch))
                charCount[ch]++;
            else
                charCount[ch] = 1;

            if (charCount[ch] > maxCount)
            {
                maxCount = charCount[ch];
                mostFrequentChar = ch;
            }
        }

        return mostFrequentChar;
    }

    static void Main(string [] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char mostFrequentChar = FindMostFrequentCharacter(input);

        Console.WriteLine("Most Frequent Character: " +mostFrequentChar);
    }
}
