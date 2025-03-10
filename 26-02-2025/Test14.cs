using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
class Test14
{
public static void Print()
{
string csvFilePath = &quot;dat2.csv&quot;; // CSV file to read
CreateCsvFile(csvFilePath); // Create sample CSV file
if (File.Exists(csvFilePath))
{
// Read CSV and convert to JSON
string[] csvLines = File.ReadAllLines(csvFilePath);
if (csvLines.Length &gt; 1)
{
string[] headers = csvLines[0].Split(&#39;,&#39;);
List&lt;Dictionary&lt;string, string&gt;&gt; records = new
List&lt;Dictionary&lt;string, string&gt;&gt;();
for (int i = 1; i &lt; csvLines.Length; i++)
{
string[] values = csvLines[i].Split(&#39;,&#39;);
Dictionary&lt;string, string&gt; record = new
Dictionary&lt;string, string&gt;();
for (int j = 0; j &lt; headers.Length; j++)
{
record[headers[j]] = values[j];
}
records.Add(record);
}
string json = JsonConvert.SerializeObject(records,
Formatting.Indented);
Console.WriteLine(&quot;Converted JSON:\n&quot; + json);
}
else
{
Console.WriteLine(&quot;CSV file is empty.&quot;);
}
}
else
{
Console.WriteLine(&quot;CSV file not found.&quot;);

}
}
// Function to create a sample CSV file
public static void CreateCsvFile(string filePath)
{
if (!File.Exists(filePath))
{
string csvData =
&quot;Name,Age,Email\nShivam,25,shivam@gmail.com\nRahul,30,rahul@gmail.com&quot;;
File.WriteAllText(filePath, csvData);
Console.WriteLine($&quot;CSV file created: {filePath}&quot;);
}
}
