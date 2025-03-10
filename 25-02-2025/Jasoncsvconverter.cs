using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

class JsonCsvConverter
{
public static void Print()

{
string jsonFilePath = "students.json";
string csvFilePath = "students.csv";
string convertedJsonFilePath = "students_converted.json";

if (!File.Exists(jsonFilePath))
{
List<Student> students = new List<Student>
{
new Student(101, "Somesh", 20, 85),
new Student(102, "Shubham", 22, 78),
new Student(103, "Yash", 21, 92),
new Student(104, "Aadi", 23, 88)
};
File.WriteAllText(jsonFilePath,

JsonConvert.SerializeObject(students, Formatting.Indented));
Console.WriteLine($"Sample JSON file created:

{jsonFilePath}");
}
// Convert JSON to CSV
ConvertJsonToCsv(jsonFilePath, csvFilePath);
// Convert CSV back to JSON
ConvertCsvToJson(csvFilePath, convertedJsonFilePath);
}
// Convert JSON to CSV
static void ConvertJsonToCsv(string jsonFile, string csvFile)
{
if (!File.Exists(jsonFile))
{
Console.WriteLine("Error: JSON file not found!");
return;
}
string jsonData = File.ReadAllText(jsonFile);
List<Student> students =
JsonConvert.DeserializeObject<List<Student>>(jsonData);
using (StreamWriter writer = new StreamWriter(csvFile))
{

writer.WriteLine("ID,Name,Age,Marks"); // CSV Header
foreach (var student in students)
{

writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Ma
rks}");
}
}
Console.WriteLine($"JSON converted to CSV: {csvFile}");
}
// Convert CSV back to JSON
static void ConvertCsvToJson(string csvFile, string jsonFile)
{
if (!File.Exists(csvFile))
{
Console.WriteLine("Error: CSV file not found!");
return;
}
List<Student> students = new List<Student>();
using (StreamReader reader = new StreamReader(csvFile))
{
string headerLine = reader.ReadLine(); // Read and ignore

header

string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values.Length == 4)
{
students.Add(new Student(
int.Parse(values[0]),
values[1],
int.Parse(values[2]),
int.Parse(values[3])
));
}
}
}

File.WriteAllText(jsonFile,
JsonConvert.SerializeObject(students, Formatting.Indented));
Console.WriteLine($"CSV converted back to JSON: {jsonFile}");
}
}
// Student class
class Student
{
public int ID { get; }
public string Name { get; }
public int Age { get; }
public int Marks { get; }
public Student(int id, string name, int age, int marks)
{
ID = id;
Name = name;
Age = age;
Marks = marks;
}
}