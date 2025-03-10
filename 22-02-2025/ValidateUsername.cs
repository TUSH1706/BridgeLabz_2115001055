using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ValidateUsername
    {
        static bool IsValidUsername(string username)
        {
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
            return Regex.IsMatch(username, pattern);
        }

        public static void Print()
        {
            string[] testUsernames = { "user_123", "123user", "us", "valid_name", "TooLongUsername12345" };
            foreach (string username in testUsernames)
            {
                Console.WriteLine($"{username}: {(IsValidUsername(username) ? "Valid" : "Invalid")}");
            }
        }
    }
}
