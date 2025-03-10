using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile
{
public class FilterStudent
{
public static void Print()
{
string filePath = "D:\\Dotnet

Framework\\Assignment32\\CSVFile\\CSVFile\\students.csv";

if (File.Exists(filePath))
{
using (StreamReader reader = new StreamReader(filePath))
{
string headerLine = reader.ReadLine();
Console.WriteLine("Students who scored more than 80

marks:");

string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');

if (int.TryParse(values[3], out int marks) &&

marks > 80)

{
Console.WriteLine($"ID: {values[0]}, Name:

{values[1]}, Age: {values[2]}, Marks: {values[3]}");

}
}
}
}
else
{
Console.WriteLine("File not found.");
}
}
}
