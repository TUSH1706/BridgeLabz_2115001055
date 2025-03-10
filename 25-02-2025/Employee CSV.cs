using System;
using System.Collections.Generic;
using System.IO;
class EmployeeCsvProcessor
{
public static void Print()
{
string inputCsvFile = "employeeees.csv";
string outputCsvFile = "employees_report.csv";

if (!File.Exists(inputCsvFile))
{
File.WriteAllLines(inputCsvFile, new[]
{
"101,Somesh,IT,75000",
"102,Bengoli Smith,HR,68000",
"103,Yash,Finance,85000",
"104,Shubham,IT,72000",
"105,Aadi,Marketing,65000"
});
Console.WriteLine("Sample input CSV file created.");
}

GenerateCsvReport(inputCsvFile, outputCsvFile);
Console.WriteLine($"CSV Report Generated: {outputCsvFile}");
}
static void GenerateCsvReport(string inputFile, string outputFile)
{
if (!File.Exists(inputFile))
{
Console.WriteLine("Error: Input CSV file not found!");
return;
}
List<string> employeeRecords = new List<string>();

using (StreamReader reader = new StreamReader(inputFile))
{

string line;
while ((line = reader.ReadLine()) != null)
{
employeeRecords.Add(line);
}
}

using (StreamWriter writer = new StreamWriter(outputFile))
{
writer.WriteLine("Employee ID,Name,Department,Salary"); //

Header

foreach (var record in employeeRecords)
{
writer.WriteLine(record); // Write each employee data
}
}
}
