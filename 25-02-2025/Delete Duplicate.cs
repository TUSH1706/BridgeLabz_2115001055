using System;
using System.IO;
using System.Collections.Generic;
class DetectDuplicatesCSV
{
public static void Print()
{
string filePath = "D:\\Dotnet
Framework\\Assignment32\\CSVFile\\CSVFile\\duplicate.csv";
Dictionary<int, string> uniqueRecords = new Dictionary<int,
string>();
HashSet<int> duplicateIds = new HashSet<int>();
if (!File.Exists(filePath))
{
Console.WriteLine("File not found: " + filePath);
return;
}

using (StreamReader reader = new StreamReader(filePath))
{
string header = reader.ReadLine();
Console.WriteLine("Duplicate Records Found:");
string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values.Length >= 2 && int.TryParse(values[0], out

int id))

{
if (uniqueRecords.ContainsKey(id))
{
duplicateIds.Add(id); // Mark as duplicate
Console.WriteLine(line); // Print duplicate

record

}
else
{
uniqueRecords[id] = line; // Store unique record
}
}
}
}
if (duplicateIds.Count == 0)
Console.WriteLine("No duplicate records found.");
}
