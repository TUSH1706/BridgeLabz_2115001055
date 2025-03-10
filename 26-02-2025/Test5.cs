using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
class Test5
{
public static void Print()
{
// Define JSON schema
string schemaJson = @&quot;{
&#39;type&#39;: &#39;object&#39;,
&#39;properties&#39;: {
&#39;Name&#39;: { &#39;type&#39;: &#39;string&#39; },
&#39;Email&#39;: { &#39;type&#39;: &#39;string&#39;, &#39;format&#39;: &#39;email&#39; },
&#39;Age&#39;: { &#39;type&#39;: &#39;integer&#39; }
},
&#39;required&#39;: [&#39;Name&#39;, &#39;Email&#39;, &#39;Age&#39;]
}&quot;;
JSchema schema = JSchema.Parse(schemaJson);
// JSON object to validate
string jsonString = @&quot;{
&#39;Name&#39;: &#39;Shivam Kumar Rajput&#39;,
&#39;Email&#39;: &#39;shivam@example.com&#39;,
&#39;Age&#39;: 25
}&quot;;
JObject jsonObject = JObject.Parse(jsonString);
// Validate JSON
bool isValid = jsonObject.IsValid(schema, out IList&lt;string&gt; errors);
if (isValid)
{
Console.WriteLine(&quot;JSON is valid!&quot;);
}
else
{
Console.WriteLine(&quot;JSON is invalid:&quot;);
foreach (string error in errors)
{

Console.WriteLine(&quot;- &quot; + error);
}
}
}
