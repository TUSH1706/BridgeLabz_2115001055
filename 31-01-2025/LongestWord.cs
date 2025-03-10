using System;

class LongestWord
{
   
    static string FindLongestWord(string sentence)
    {
        string longestWord = "";
        string currentWord = "";
        
        for (int i = 0; i < sentence.Length; i++)
        {
            char currentChar = sentence[i];

            if (Char.IsLetterOrDigit(currentChar)) 
            {
                currentWord += currentChar;
            }
            else
            {
                if (currentWord.Length > longestWord.Length)  
                {
                    longestWord = currentWord;
                }
                currentWord = ""; 
            }
        }

        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        return longestWord;
    }
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("The longest word in the sentence is: " + longestWord);
    }
}
