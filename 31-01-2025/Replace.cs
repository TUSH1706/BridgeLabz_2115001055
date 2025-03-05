using System;

class Replace
{
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        int oldWordLength = oldWord.Length;
        int sentenceLength = sentence.Length;
        string result = "";

        int i = 0;
        while (i < sentenceLength)
        {
            if (i + oldWordLength <= sentenceLength && sentence.Substring(i, oldWordLength) == oldWord)
            {
                result += newWord; 
                i += oldWordLength; 
            }
            else
            {
                result += sentence[i]; 
				i++;
            }
        }

        return result;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();
        string result = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Modified sentence: " + result);
    }
}
