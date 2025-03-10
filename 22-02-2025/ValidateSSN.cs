using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ValidateSSN
    {
        static bool IsValidSSN(string text)
        {
            string pattern = @"\b\d{3}-\d{2}-\d{4}\b";
            Match match = Regex.Match(text, pattern);
            return match.Success;
        }

        public static void Print()
        {
            string[] testInputs = { "123-45-6789", "123456789", "12-345-6789", "123-4-6789", "987-65-4321" };

            foreach (string input in testInputs)
            {
                Console.WriteLine($"{input}: {(IsValidSSN(input) ? "✅ Valid" : "❌ Invalid")}");
            }
        }
    }
}
