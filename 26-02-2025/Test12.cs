using System;
using System.IO;
using Newtonsoft.Json.Linq;
class Test12{
public static void Print(){
string file1Path = &quot;file1.json&quot;;
string file2Path = &quot;file2.json&quot;;
// Create JSON files
CreateJsonFile(file1Path, @&quot;{ &#39;Name&#39;: &#39;Shivam Kumar Rajput&#39;, &#39;Age&#39;:
25, &#39;Email&#39;: &#39;shivam@gmail.com&#39; }&quot;);
CreateJsonFile(file2Path, @&quot;{ &#39;City&#39;: &#39;Dibai&#39;, &#39;Country&#39;: &#39;India&#39;,
&#39;Phone&#39;: &#39;1234567890&#39; }&quot;);
// Merge JSON files
if (File.Exists(file1Path) &amp;&amp; File.Exists(file2Path))
{
string json1 = File.ReadAllText(file1Path);
string json2 = File.ReadAllText(file2Path);
JObject jsonObject1 = JObject.Parse(json1);
JObject jsonObject2 = JObject.Parse(json2);
jsonObject1.Merge(jsonObject2, new JsonMergeSettings
{
MergeArrayHandling = MergeArrayHandling.Union
});
string mergedJson = jsonObject1.ToString();
Console.WriteLine(&quot;Merged JSON:\n&quot; + mergedJson);
}
else
{
Console.WriteLine(&quot;One or both JSON files not found.&quot;);
}
}
// Function to create a JSON file
public static void CreateJsonFile(string filePath, string jsonData)
{

if (!File.Exists(filePath))
{
File.WriteAllText(filePath, jsonData);
Console.WriteLine($&quot;File created: {filePath}&quot;);
}
else
{
Console.WriteLine($&quot;File already exists: {filePath}&quot;);
}
}
