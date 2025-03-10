using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
class WordFrequencyCounter
{
    static void Main()
    {
        string filePath = "sample.txt"; 

        try
        {
            Dictionary<string, int> wordCounts = CountWords(filePath);
            DisplayTopWords(wordCounts, 5);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
    }
    static Dictionary<string, int> CountWords(string filePath)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            char[] separators = new char[] { ' ', '\t', '\n', '\r', ',', '.', ';', ':', '!', '?', '(', ')', '[', ']', '{', '}', '"', '\'' };

            while ((line = reader.ReadLine()) != null) // Read file line by line
            {
                string[] words = line.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (wordFrequency.ContainsKey(word))
                        wordFrequency[word]++;
                    else
                        wordFrequency[word] = 1;
                }
            }
        }
        return wordFrequency;
    }
    static void DisplayTopWords(Dictionary<string, int> wordFrequency, int topN)
    {
        var sortedWords = wordFrequency.OrderByDescending(w => w.Value).Take(topN);

        Console.WriteLine($"Top {topN} most frequent words:");
        foreach (var word in sortedWords)
        {
            Console.WriteLine($"{word.Key}: {word.Value} times");
        }
    }
}
