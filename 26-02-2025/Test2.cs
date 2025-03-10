using System;
using Newtonsoft.Json;
class Test2
{
public static void Print()
{
Car car = new Car
{
Brand = &quot;Tesla&quot;,
Model = &quot;Model S&quot;,
Year = 2024
};

// Convert object to JSON
string json = JsonConvert.SerializeObject(car, Formatting.Indented);
Console.WriteLine(&quot;JSON Representation:\n&quot; + json);
}
}
class Car
{
public string Brand { get; set; }
public string Model { get; set; }
public int Year { get; set; }
}