using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
class Test13
{
public static void Print()
{
string json = @&quot;{
&#39;Name&#39;: &#39;Shivam Kumar Rajput&#39;,
&#39;Age&#39;: 25,
&#39;Email&#39;: &#39;shivam@example.com&#39;
}&quot;;
// Convert JSON to XML
JObject jsonObject = JObject.Parse(json);
XDocument xmlDocument =
JsonConvert.DeserializeXNode(jsonObject.ToString(), &quot;Root&quot;);
// Print XML format
Console.WriteLine(&quot;Converted XML:\n&quot; + xmlDocument);
}
