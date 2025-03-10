using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class Test10{
public static void Print()
{
string json = @&quot;[
{ &#39;Name&#39;: &#39;Shivam Kumar Rajput&#39;, &#39;Age&#39;: 25, &#39;Email&#39;:
&#39;shivam@example.com&#39; },
{ &#39;Name&#39;: &#39;Rahul Sharma&#39;, &#39;Age&#39;: 30, &#39;Email&#39;:
&#39;rahul@example.com&#39; },
{ &#39;Name&#39;: &#39;Amit Verma&#39;, &#39;Age&#39;: 28, &#39;Email&#39;: &#39;amit@example.com&#39;
},
{ &#39;Name&#39;: &#39;John Doe&#39;, &#39;Age&#39;: 24, &#39;Email&#39;: &#39;john@example.com&#39; }
]&quot;;
// Parse JSON array
JArray jsonArray = JArray.Parse(json);
// Filter users older than 25
var filteredUsers = jsonArray.Where(user =&gt; (int)user[&quot;Age&quot;] &gt; 25);
// Convert filtered users back to JSON
string filteredJson = JsonConvert.SerializeObject(filteredUsers,
Formatting.Indented);
Console.WriteLine(&quot;Filtered JSON (Users Age &gt; 25):\n&quot; +
filteredJson);
}
