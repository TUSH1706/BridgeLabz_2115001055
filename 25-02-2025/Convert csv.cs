using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSVFile
{
internal class Student
{
public int ID { get; set; }
public string Name { get; set; }
public int Age { get; set; }
public int Marks { get; set; }
public override string ToString()
{
return $"Student{{ID={ID}, Name='{Name}', Age={Age},

Marks={Marks}}}";
}
}

class CSVToCSharpObjects
{
public static void Print()
{
string filePath = "D:\\Dotnet

Framework\\Assignment32\\CSVFile\\CSVFile\\students.csv";
List<Student> students = new List<Student>();
if (File.Exists(filePath))
{
using (StreamReader reader = new StreamReader(filePath))
{
string headerLine = reader.ReadLine(); // Skip

header row

string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values.Length == 4) // Ensure correct number

of columns

{
Student student = new Student
{
ID = int.Parse(values[0].Trim()),
Name = values[1].Trim(),
Age = int.Parse(values[2].Trim()),
Marks = int.Parse(values[3].Trim())
};
students.Add(student);
}
}
}
// Print student objects
foreach (var student in students)
{
Console.WriteLine(student);
}
}
else
{
Console.WriteLine("File not found.");

}
}
}

