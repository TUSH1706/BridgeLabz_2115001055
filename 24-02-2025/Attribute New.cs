
using System;

// Define the ImportantMethod attribute with an optional Level parameter
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class ImportantMethodAttribute : Attribute
{
    // Property to store the level of importance
    public string Level { get; }

    // Constructor to initialize the level (defaults to "HIGH" if not provided)
    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

public class TaskManager
{
    // Apply the ImportantMethod attribute to a method
    [ImportantMethod(Level = "HIGH")]
    public void CriticalTask()
    {
        Console.WriteLine("Executing critical task...");
    }

    // Apply the ImportantMethod attribute to another method with default level
    [ImportantMethod]
    public void RegularTask()
    {
        Console.WriteLine("Executing regular task...");
    }
}

using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Create an instance of TaskManager
        TaskManager taskManager = new TaskManager();

        // Get the type of the TaskManager class
        Type taskManagerType = typeof(TaskManager);

        // Retrieve all methods in TaskManager that are annotated with ImportantMethod
        MethodInfo[] methods = taskManagerType.GetMethods();

        // Print all methods that have the ImportantMethod attribute
        Console.WriteLine("Important Methods:");

        foreach (MethodInfo method in methods)
        {
            // Check if the method has the ImportantMethod attribute
            var attribute = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attribute != null)
            {
                Console.WriteLine($"Method: {method.Name}, Importance Level: {attribute.Level}");
            }
        }
    }
}


