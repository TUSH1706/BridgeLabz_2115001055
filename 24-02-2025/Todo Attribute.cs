
using System;

// Define the Todo attribute with Task, AssignedTo, and Priority fields
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    // Fields for task description, assigned developer, and priority
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    // Constructor to initialize the fields (with default priority)
    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

public class ProjectManager
{
    // Method with Todo attribute
    [Todo("Implement user authentication", "Alice", "HIGH")]
    public void Authentication()
    {
        Console.WriteLine("Authentication method is under development.");
    }

    // Method with Todo attribute
    [Todo("Design database schema", "Bob")]
    public void DatabaseDesign()
    {
        Console.WriteLine("Database design method is under development.");
    }

    // Method with Todo attribute
    [Todo("Create API documentation", "Charlie", "LOW")]
    public void ApiDocumentation()
    {
        Console.WriteLine("API documentation is under development.");
    }
}

using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Create an instance of ProjectManager
        ProjectManager projectManager = new ProjectManager();

        // Get the type of the ProjectManager class
        Type projectManagerType = typeof(ProjectManager);

        // Retrieve all methods in ProjectManager
        MethodInfo[] methods = projectManagerType.GetMethods();

        // Print all methods that have the Todo attribute
        Console.WriteLine("Pending Tasks:");

        foreach (MethodInfo method in methods)
        {
            // Check if the method has the Todo attribute
            var todoAttributes = method.GetCustomAttributes(typeof(TodoAttribute), false);

            // If the method has Todo attributes, print the task details
            foreach (TodoAttribute todo in todoAttributes)
            {
                Console.WriteLine($"Method: {method.Name}");
                Console.WriteLine($"- Task: {todo.Task}");
                Console.WriteLine($"- Assigned to: {todo.AssignedTo}");
                Console.WriteLine($"- Priority: {todo.Priority}");
                Console.WriteLine();
            }
        }
    }
}



