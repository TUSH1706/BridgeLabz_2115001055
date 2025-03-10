using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ExtractDate
    {
        static void ExtractDates(string text)
        {
            string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + ", ");
            }
        }

        public static void Print()
        {
            string sampleText = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
            Console.Write("Extracted Dates: ");
            ExtractDates(sampleText);
        }
    }
}
