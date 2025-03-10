using System;
using System.IO;
class LargeCSVReader
{
public static void Print()
{
string filePath = "large_data.csv";
int batchSize = 100;
int totalRecordsProcessed = 0;
if (!File.Exists(filePath))
{
Console.WriteLine("File not found: " + filePath);
return;
}
using (StreamReader reader = new StreamReader(filePath))
{
string header = reader.ReadLine();
string line;
int batchCount = 0;
while ((line = reader.ReadLine()) != null)
{
batchCount++;
totalRecordsProcessed++;
// Simulate processing (printing first record of each

batch)

if (batchCount == 1)
Console.WriteLine($"Processing: {line}");

// Process in chunks of batchSize
if (batchCount == batchSize)
{
Console.WriteLine($"Processed
{totalRecordsProcessed} records so far...");

batchCount = 0; // Reset batch count
}
}
}
Console.WriteLine($"Total records processed:
{totalRecordsProcessed}");
}
