using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSVFile
{
public class ReadCountRows
{
public static void Print()
{
string filePath = "employees.csv";
if (File.Exists(filePath))
{
int recordCount = 0;

using (StreamReader reader = new StreamReader(filePath))
{
// Read the header line and ignore it
string headerLine = reader.ReadLine();
// Read remaining lines and count them
while (reader.ReadLine() != null)
{
recordCount++;
}
}
Console.WriteLine($"Total number of records (excluding

header): {recordCount}");

}
else
{
Console.WriteLine("File not found.");
}
}
}

