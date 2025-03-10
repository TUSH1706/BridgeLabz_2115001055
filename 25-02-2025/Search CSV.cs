using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSVFile
{
internal class SearchRecord
{
public static void Print()
{
string filePath = "employees.csv";
Console.Write("Enter employee name to search: ");
string searchName = Console.ReadLine();
bool found = false;
if (File.Exists(filePath))
{
using (StreamReader reader = new StreamReader(filePath))
{
string headerLine = reader.ReadLine();
string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
// Check if the name matches (case-insensitive)
if (values[1].Trim().Equals(searchName,

StringComparison.OrdinalIgnoreCase))

{
Console.WriteLine($"Employee Found:

Department: {values[2]}, Salary: {values[3]}");
found = true;

break;
}
}
}
if (!found)
{
Console.WriteLine("Employee not found.");
}
}
else
{
Console.WriteLine("File not found.");
}
}
}

}