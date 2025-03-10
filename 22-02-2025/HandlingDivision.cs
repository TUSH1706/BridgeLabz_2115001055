using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class ValidateNumberPlate
    {
        static bool IsValidLicensePlate(string plate)
        {
            string pattern = @"^[A-Z]{2}\d{4}$";
            return Regex.IsMatch(plate, pattern);
        }

        public static void Print()
        {
            string[] testPlates = { "AB1234", "A12345", "XYZ7890", "CD5678", "AA12B3" };
            foreach (string plate in testPlates)
            {
                Console.WriteLine($"{plate}: {(IsValidLicensePlate(plate) ? "Valid" : "Invalid")}");
            }
        }
    }
}
