using System;
using System.Collections.Generic;
using Newtonsoft.Json;
class Test6
{
public static void Print()
{
// List of Vehicle objects
List&lt;Vehicle&gt; vehicles = new List&lt;Vehicle&gt;
{
new Vehicle { Brand = &quot;Tesla&quot;, Model = &quot;Model S&quot;, Year = 2024 },
new Vehicle { Brand = &quot;BMW&quot;, Model = &quot;X5&quot;, Year = 2023 },
new Vehicle { Brand = &quot;Audi&quot;, Model = &quot;Q7&quot;, Year = 2022 }
};
// Convert list to JSON array
string jsonArray = JsonConvert.SerializeObject(vehicles,
Formatting.Indented);
Console.WriteLine(&quot;JSON Array:\n&quot; + jsonArray);
}
}
// Vehicle class
class Vehicle
{
public string Brand { get; set; }
public string Model { get; set; }
public int Year { get; set; }
}