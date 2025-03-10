using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Newtonsoft.Json;
class Test15
{
public static void Print()
{
string dbPath = &quot;database.db&quot;;
string jsonFilePath = &quot;report.json&quot;;

List&lt;Dictionary&lt;string, object&gt;&gt; records = FetchRecords(dbPath);
string jsonReport = JsonConvert.SerializeObject(records,
Formatting.Indented);
File.WriteAllText(jsonFilePath, jsonReport);
Console.WriteLine($&quot;JSON Report saved to: {jsonFilePath}&quot;);
Console.WriteLine(&quot;Generated JSON Report:\n&quot; + jsonReport);
}

public static List&lt;Dictionary&lt;string, object&gt;&gt; FetchRecords(string

dbPath)
{
List&lt;Dictionary&lt;string, object&gt;&gt; records = new
List&lt;Dictionary&lt;string, object&gt;&gt;();
using (var connection = new SQLiteConnection($&quot;Data
Source={dbPath};Version=3;&quot;))
{
connection.Open();
string selectQuery = &quot;SELECT * FROM Students&quot;;
SQLiteCommand command = new SQLiteCommand(selectQuery,
connection);
using (SQLiteDataReader reader = command.ExecuteReader())
{
while (reader.Read())
{
Dictionary&lt;string, object&gt; record = new
Dictionary&lt;string, object&gt;();
for (int i = 0; i &lt; reader.FieldCount; i++)
{
record[reader.GetName(i)] = reader.GetValue(i);
}
records.Add(record);
}
}
}
return records;
}
