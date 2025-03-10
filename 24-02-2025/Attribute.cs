
using System;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class TaskInfoAttribute : Attribute
{
    // Properties to store the task priority and assigned person
    public int Priority { get; }
    public string AssignedTo { get; }

    // Constructor to initialize the attribute
    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

public class TaskManager
{
    // Apply the TaskInfo attribute to a method
    [TaskInfo(1, "John Doe")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed!");
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

        // Get the MethodInfo object for the CompleteTask method
        MethodInfo methodInfo = typeof(TaskManager).GetMethod("CompleteTask");

        // Retrieve the TaskInfo attribute applied to the method
        TaskInfoAttribute taskInfo = (TaskInfoAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(TaskInfoAttribute));

        // Check if the TaskInfo attribute is applied
        if (taskInfo != null)
        {
            // Print out the details of the TaskInfo attribute
            Console.WriteLine($"Task Priority: {taskInfo.Priority}");
            Console.WriteLine($"Assigned To: {taskInfo.AssignedTo}");
        }
        else
        {
            Console.WriteLine("No TaskInfo attribute found.");
        }

        // Optionally, call the method
        taskManager.CompleteTask();
    }
}

