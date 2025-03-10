using System;
using Newtonsoft.Json;
class Test1{
public static void Print(){
var student = new
{
Name = &quot;Shivam Kumar Rajput&quot;,
Age = 20,
Subjects = new string[] { &quot;Math&quot;, &quot;Science&quot;, &quot;History&quot; }
};
// Convert object to JSON
string json = JsonConvert.SerializeObject(student,
Formatting.Indented);
Console.WriteLine(&quot;JSON Representation:\n&quot; + json);
}
