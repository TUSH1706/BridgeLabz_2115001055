using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ExtractProgrammingLanguages
    {
        static void ExtractProgrammingLanguage(string text)
        {
            string pattern = @"\b(JavaScript|Java|Python|C\+\+|C#|Go|Ruby|Swift|Kotlin|PHP|Rust|TypeScript|Perl|R|Dart|Scala|Haskell)\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + ", ");
            }
        }

        public static void Print()
        {
            string sampleText = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
            Console.Write("Extracted Languages: ");
            ExtractProgrammingLanguage(sampleText);
        }
    }
}
