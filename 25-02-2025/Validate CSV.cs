using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace CSVFile
{
internal class ValidateCSV
{
public static void Print()
{
string filePath = "D:\\Dotnet

Framework\\Assignment32\\CSVFile\\CSVFile\\sample.csv";

if (File.Exists(filePath))
{
using (StreamReader reader = new StreamReader(filePath))
{
string headerLine = reader.ReadLine();
Console.WriteLine(headerLine);
Regex emailRegex = new

Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Email regex

Regex phoneRegex = new Regex(@"^\d{10}$"); // Phone

number should be exactly 10 digits

List<string> invalidRows = new List<string>();

string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values.Length < 4)
{
invalidRows.Add($"Invalid row (missing

columns): {line}");

continue;
}
string email = values[2].Trim();
string phone = values[3].Trim();
bool isValidEmail = emailRegex.IsMatch(email);
bool isValidPhone = phoneRegex.IsMatch(phone);
if (!isValidEmail || !isValidPhone)
{
string errorMsg = $"Invalid row: {line} - ";
errorMsg += !isValidEmail ? "Invalid Email.

" : "";

errorMsg += !isValidPhone ? "Invalid Phone

Number. " : "";

invalidRows.Add(errorMsg);
}
}

if (invalidRows.Count > 0)
{
Console.WriteLine("\nInvalid Records:");
foreach (var error in invalidRows)
{
Console.WriteLine(error);
}
}
else
{
Console.WriteLine("All records are valid.");
}
}

}
else
{
Console.WriteLine("File not found.");
}
}
}

