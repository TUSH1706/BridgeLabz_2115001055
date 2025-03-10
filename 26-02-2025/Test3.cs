using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class Test3
{
public static void Print(){
string filePath = &quot;data.json&quot;;
CreateJsonFile(filePath); // Create JSON file
ReadJsonFile(filePath); // Read and extract fields
}
public static void CreateJsonFile(string filePath){
var person = new
{
Name = &quot;Shivam Kumar Rajput&quot;,
Email = &quot;shivam@gmail.com&quot;,
Age = 22,
Address = &quot;India&quot;
};
string json = JsonConvert.SerializeObject(person,
Formatting.Indented);
File.WriteAllText(filePath, json);
Console.WriteLine(&quot;JSON file created successfully.&quot;);
}
public static void ReadJsonFile(string filePath) {
if (File.Exists(filePath)) {

string jsonContent = File.ReadAllText(filePath);
JObject jsonObject = JObject.Parse(jsonContent);
string name = jsonObject[&quot;Name&quot;]?.ToString();
string email = jsonObject[&quot;Email&quot;]?.ToString();
Console.WriteLine($&quot;Name: {name}&quot;);
Console.WriteLine($&quot;Email: {email}&quot;);
} else {
Console.WriteLine(&quot;JSON file not found.&quot;);
}
}
