using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ReplaceMultipleSpacesWithSingleSpace
    {
        static string ReplaceMultipleSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", " ").Trim();
        }

        public static void Print()
        {
            string input = "This is an example with multiple spaces.";
            string output = ReplaceMultipleSpaces(input);
            Console.WriteLine($"Original: \"{input}\"");
            Console.WriteLine($"Processed: \"{output}\"");
        }
    }
}
