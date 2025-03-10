using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ExtractCapitalizedWord
    {
        static void ExtractCapitalizedWords(string text)
        {
            string pattern = @"\b[A-Z][a-z]*\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + ", ");
            }
        }

        public static void Print()
        {
            string sampleText = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            Console.Write("Capitalized Words: ");
            ExtractCapitalizedWords(sampleText);
        }
    }
}
