using System;
using System.Collections.Generic;
using Newtonsoft.Json;
class Test9{
public static void Print(){
// List of Employee objects
List&lt;Employee&gt; employees = new List&lt;Employee&gt;
{
new Employee { Name = &quot;Shivam Kumar Rajput&quot;, Age = 25, Position
= &quot;Software Engineer&quot; },
new Employee { Name = &quot;Pramendra Pratap Singh&quot;, Age = 30,
Position = &quot;Project Manager&quot; },
new Employee { Name = &quot;Ashish Verma&quot;, Age = 28, Position = &quot;Data
Analyst&quot; }
};
// Convert list to JSON array
string jsonArray = JsonConvert.SerializeObject(employees,
Formatting.Indented);
Console.WriteLine(&quot;JSON Array:\n&quot; + jsonArray);
}

}
// Employee class
class Employee{
public string Name { get; set; }
public int Age { get; set; }
public string Position { get; set; }
}