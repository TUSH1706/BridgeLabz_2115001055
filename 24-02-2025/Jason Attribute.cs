
using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = false)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

public class User
{
    [JsonField("user_name")]
    public string Username { get; set; }

    [JsonField("user_age")]
    public int Age { get; set; }

    [JsonField("user_email")]
    public string Email { get; set; }
}

public class JsonSerializer
{
    public static string ToJson(object obj)
    {
        var jsonFields = new Dictionary<string, object>();

        // Get all fields and properties of the object
        foreach (var property in obj.GetType().GetProperties())
        {
            var attribute = property.GetCustomAttribute<JsonFieldAttribute>();

            // If the property has the JsonField attribute, get the custom name and value
            if (attribute != null)
            {
                var customName = attribute.Name;
                var value = property.GetValue(obj);
                jsonFields[customName] = value;
            }
        }

        // Convert the dictionary to a JSON string
        return JsonConvert.SerializeObject(jsonFields, Formatting.Indented);
    }
}

public class Program
{
    public static void Main()
    {
        // Create a User object
        var user = new User
        {
            Username = "JohnDoe",
            Age = 30,
            Email = "johndoe@example.com"
        };

        // Convert the User object to JSON string
        string jsonString = JsonSerializer.ToJson(user);
        
        // Print the JSON string
        Console.WriteLine(jsonString);
    }
}


