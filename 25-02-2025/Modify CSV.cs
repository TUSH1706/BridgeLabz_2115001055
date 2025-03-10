using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSVFile
{
internal class UpdateExistingCSV
{
public static void Print()
{

string inputFilePath = "employees.csv";
string outputFilePath = "updated_employees.csv";
if (File.Exists(inputFilePath))
{
using (StreamReader reader = new

StreamReader(inputFilePath))

using (StreamWriter writer = new

StreamWriter(outputFilePath))

{
string headerLine = reader.ReadLine();
writer.WriteLine(headerLine);
string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values[2].Trim().Equals("IT",

StringComparison.OrdinalIgnoreCase))

{
// Parse and increase salary by 10%
if (decimal.TryParse(values[3], out decimal

salary))

{
salary *= 1.10m; // Increase by 10%
values[3] = salary.ToString("F2");
}
}
// Write updated line to new CSV
writer.WriteLine(string.Join(",", values));
}
}
Console.WriteLine("Updated salaries saved in

'updated_employees.csv'.");

}
else
{
Console.WriteLine("File not found.");
}
}
}

