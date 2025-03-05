using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of sentences: ");
        int n = int.Parse(Console.ReadLine());
        string[] sentences = new string[n];
        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++)
        {
            sentences[i] = Console.ReadLine();
        }
        Console.Write("Enter the word to search for: ");
        string word = Console.ReadLine();
        string foundSentence = FindSentenceWithWord(sentences, word);
        if (foundSentence != null)
            Console.WriteLine("First sentence containing the word \"" + word + "\":" + foundSentence);
        else
            Console.WriteLine("No sentence contains the word \"" + word + "\".");
    }
    static string FindSentenceWithWord(string[] sentences, string word)
    {
        foreach (string sentence in sentences)
        {
            if (sentence.Contains(word))
                return sentence;
        }
        return null;
    }
}
