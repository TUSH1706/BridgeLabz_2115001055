using System;
using System.IO;
using Newtonsoft.Json.Linq;
class Test8{
public static void Print()
{

string filePath = &quot;data.json&quot;; // JSON file to read
if (File.Exists(filePath))
{
string jsonContent = File.ReadAllText(filePath);
JObject jsonObject = JObject.Parse(jsonContent);
Console.WriteLine(&quot;JSON Keys and Values:&quot;);
foreach (var item in jsonObject)
{
Console.WriteLine($&quot;{item.Key}: {item.Value}&quot;);
}
}
else
{
Console.WriteLine(&quot;JSON file not found.&quot;);
}
}
}