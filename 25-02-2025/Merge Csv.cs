using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSVFile
{
class Students
{
public int ID { get; set; }
public string Name { get; set; }
public int Age { get; set; }
public int Marks { get; set; }
public string Grade { get; set; }
public override string ToString()
{
return $"{ID},{Name},{Age},{Marks},{Grade}";
}
}
class MergeCSVFiles
{
public static void Print()

{
string file1 = "D:\\Dotnet

Framework\\Assignment32\\CSVFile\\CSVFile\\student1.csv";

string file2 = "D:\\Dotnet

Framework\\Assignment32\\CSVFile\\CSVFile\\student2.csv";
string outputFile = "merged_students.csv";
Dictionary<int, Students> studentData = new Dictionary<int,

Students>();

// Read first CSV (students1.csv)
if (File.Exists(file1))
{
using (StreamReader reader = new StreamReader(file1))
{
reader.ReadLine(); // Skip header
string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values.Length == 3 &&

int.TryParse(values[0], out int id) && int.TryParse(values[2], out int
age))

{
studentData[id] = new Students
{
ID = id,
Name = values[1].Trim(),
Age = age
};
}
}
}
}
else
{
Console.WriteLine("File not found: " + file1);
return;
}
// Read second CSV (students2.csv)
if (File.Exists(file2))
{

using (StreamReader reader = new StreamReader(file2))
{
reader.ReadLine(); // Skip header
string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values.Length == 3 &&

int.TryParse(values[0], out int id) && int.TryParse(values[1], out int
marks))

{
if (studentData.ContainsKey(id))
{
studentData[id].Marks = marks;
studentData[id].Grade =

values[2].Trim();

}
}
}
}
}
else
{
Console.WriteLine("File not found: " + file2);
return;
}
// Write merged data to a new CSV file
using (StreamWriter writer = new StreamWriter(outputFile))
{
writer.WriteLine("ID,Name,Age,Marks,Grade"); // Write

header

foreach (var student in studentData.Values)
{
writer.WriteLine(student);
}
}
Console.WriteLine($"Merged data saved to {outputFile}");
}
}
