using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ExtractCurrency
    {
        static void ExtractCurrencyValues(string text)
        {
            string pattern = @"\$\s*\d+(\.\d{2})?";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + ", ");
            }
        }

        public static void Print()
        {
            string sampleText = "The price is $45.99, and the discount is $10.50.";
            Console.Write("Extracted Currency Values: ");
            ExtractCurrencyValues(sampleText);
        }
    }
}
