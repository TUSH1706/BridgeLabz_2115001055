using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSVFile
{
public class ReadCSV
{
public static void Print()
{
string filePath = "D:\\Dotnet

Framework\\Assignment32\\CSVFile\\CSVFile\\first.csv";

// Check if file exists
if (File.Exists(filePath))
{
using (StreamReader reader = new StreamReader(filePath))
{
// Read and ignore the header line
string headerLine = reader.ReadLine();
string line;
while ((line = reader.ReadLine()) != null)
{
// Split the line into columns
string[] values = line.Split(',');
// Print the structured output
Console.WriteLine($"ID: {values[0]}, Name:

{values[1]}, Age: {values[2]}, Marks: {values[3]}");

}
}
}
else
{
Console.WriteLine("File not found.");
}
}
}

