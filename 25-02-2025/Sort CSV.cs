using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSVFile
{
internal class SortCSV
{
public static void Print()
{
string filePath = "employees.csv";
if (File.Exists(filePath))
{
List<Employee> employees = new List<Employee>();
using (StreamReader reader = new StreamReader(filePath))
{
string headerLine = reader.ReadLine(); // Read and

ignore the header

string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values.Length == 4 &&

decimal.TryParse(values[3], out decimal salary))

{
employees.Add(new Employee
{
ID = values[0],
Name = values[1],
Department = values[2],
Salary = salary
});
}
}
}
// Sort employees by salary in descending order
var topEmployees = employees.OrderByDescending(emp =>

emp.Salary).Take(5);

Console.WriteLine("Top 5 Highest-Paid Employees:");
foreach (var emp in topEmployees)
{
Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name},

Department: {emp.Department}, Salary: {emp.Salary:C}");

}
}
else
{
Console.WriteLine("File not found.");
}
}
}
// Employee class to store employee data
class Employee
{
public string ID { get; set; }
public string Name { get; set; }
public string Department { get; set; }
public decimal Salary { get; set; }
}

}