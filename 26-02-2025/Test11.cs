using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
class Test11{
public static void Print() {
string schemaJson = @&quot;{
&#39;type&#39;: &#39;object&#39;,
&#39;properties&#39;: {
&#39;Email&#39;: { &#39;type&#39;: &#39;string&#39;, &#39;format&#39;: &#39;email&#39; }
},
&#39;required&#39;: [&#39;Email&#39;]
}&quot;;
JSchema schema = JSchema.Parse(schemaJson);
List&lt;string&gt; jsonObjects = new List&lt;string&gt;
{
@&quot;{ &#39;Email&#39;: &#39;shivam@gmail.com&#39; }&quot;, // Valid Email
@&quot;{ &#39;Email&#39;: &#39;invalid-email&#39; }&quot;, // Invalid Email
@&quot;{ &#39;Name&#39;: &#39;Shivam&#39; }&quot; // Missing Email Field
};
foreach (string jsonString in jsonObjects)
{
JObject jsonObject = JObject.Parse(jsonString);
bool isValid = jsonObject.IsValid(schema, out IList&lt;string&gt;
errors);
Console.WriteLine($&quot;JSON: {jsonString}&quot;);
Console.WriteLine(isValid ? &quot;Valid Email&quot; : &quot;Invalid Email&quot;);
if (!isValid)
{
foreach (string error in errors)
{
Console.WriteLine($&quot;{error}&quot;);
}
}
Console.WriteLine();
}
}
}