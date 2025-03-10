using System;
using Newtonsoft.Json.Linq;
class Test4{
public static void Print(){
// First JSON object
JObject json1 = JObject.Parse(@&quot;{
&#39;Name&#39;: &#39;Shivam Kumar Rajput&#39;,
&#39;Email&#39;: &#39;shivam@gmail.com&#39;
}&quot;);
// Second JSON object
JObject json2 = JObject.Parse(@&quot;{
&#39;Age&#39;: 25,
&#39;Address&#39;: &#39;India&#39;
}&quot;);
// Merge json2 into json1
json1.Merge(json2, new JsonMergeSettings
{
MergeArrayHandling = MergeArrayHandling.Union
});
Console.WriteLine(&quot;Merged JSON:\n&quot; + json1.ToString());
}
