
using System;

// Define the BugReport attribute with a description field
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    // Property to store the description of the bug report
    public string Description { get; }

    // Constructor to initialize the description
    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

public class TaskManager
{
    // Apply the BugReport attribute twice on the same method
    [BugReport("Bug in the UI rendering.")]
    [BugReport("Crash when loading the data.")]
    public void PerformTask()
    {
        Console.WriteLine("Performing task...");
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

        // Get the MethodInfo object for the PerformTask method
        MethodInfo methodInfo = typeof(TaskManager).GetMethod("PerformTask");

        // Retrieve all BugReport attributes applied to the method
        object[] bugReports = methodInfo.GetCustomAttributes(typeof(BugReportAttribute), false);

        // Print all descriptions of the BugReport attributes
        Console.WriteLine("Bug Reports for PerformTask Method:");
        foreach (BugReportAttribute bugReport in bugReports)
        {
            Console.WriteLine($"- {bugReport.Description}");
        }

        // Optionally, call the method
        taskManager.PerformTask();
    }
}


