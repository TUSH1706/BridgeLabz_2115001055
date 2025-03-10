using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class CensoringBadWords
    {
        static string CensorBadWords(string text, string[] badWords)
        {
            foreach (string word in badWords)
            {
                string pattern = $@"\b{Regex.Escape(word)}\b"; // Match whole words
                text = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
            }
            return text;
        }

        public static void Print()
        {
            string input = "This is a damn bad example with some stupid words.";
            string[] badWords = { "damn", "stupid" }; // List of words to censor
            string output = CensorBadWords(input, badWords);

            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"Censored: {output}");
        }
    }
}
