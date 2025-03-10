using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSVFile
{
public class WriteCSV
{
public static void Print()
{
string filePath = "employees.csv";
// Using StreamWriter to write to a CSV file
using (StreamWriter writer = new StreamWriter(filePath))
{
// Writing the header row
writer.WriteLine("ID,Name,Department,Salary");

// Writing employee details
writer.WriteLine("1,Somesh,HR,50000");
writer.WriteLine("2,Shubham,IT,65000");
writer.WriteLine("3,Yash,Finance,55000");
writer.WriteLine("4,Aadi,Marketing,60000");
writer.WriteLine("5,Sujal,Operations,58000");
}
Console.WriteLine("CSV file 'employees.csv' has been created

successfully.");
}
}

