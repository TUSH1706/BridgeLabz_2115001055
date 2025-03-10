using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ValidateCreditCard
    {
        static bool IsValidCreditCard(string cardNumber)
        {
            string pattern = @"^4\d{15}$|^5\d{15}$";
            return Regex.IsMatch(cardNumber, pattern);
        }

        public static void Print()
        {
            string[] testCards = { "4111111111111111", "5112345678901234", "1234567812345678", "4222222222222", "5999999999999999" };
            foreach (string card in testCards)
            {
                Console.WriteLine($"{card}: {(IsValidCreditCard(card) ? "Valid" : "Invalid")}");
            }
        }
    }
}
