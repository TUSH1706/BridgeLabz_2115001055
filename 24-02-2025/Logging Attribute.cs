
using System;

// Define the LogExecutionTime attribute
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class LogExecutionTimeAttribute : Attribute
{
    // This attribute has no parameters for now, it's just used to mark methods
}

using System;
using System.Diagnostics;

public class TaskManager
{
    // Apply the LogExecutionTime attribute to a method
    [LogExecutionTime]
    public void TaskOne()
    {
        Console.WriteLine("Task One started...");
        // Simulate work with a delay
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Task One completed.");
    }

    // Apply the LogExecutionTime attribute to another method
    [LogExecutionTime]
    public void TaskTwo()
    {
        Console.WriteLine("Task Two started...");
        // Simulate work with a delay
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Task Two completed.");
    }

    // Apply the LogExecutionTime attribute to another method
    [LogExecutionTime]
    public void TaskThree()
    {
        Console.WriteLine("Task Three started...");
        // Simulate work with a delay
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Task Three completed.");
    }
}

using System;
using System.Reflection;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Create an instance of TaskManager
        TaskManager taskManager = new TaskManager();

        // Get the type of the TaskManager class
        Type taskManagerType = typeof(TaskManager);

        // Retrieve all methods in TaskManager
        MethodInfo[] methods = taskManagerType.GetMethods();

        // Iterate through all methods and log execution time for those with LogExecutionTime attribute
        foreach (MethodInfo method in methods)
        {
            // Check if the method has the LogExecutionTime attribute
            var logExecutionTimeAttribute = method.GetCustomAttribute<LogExecutionTimeAttribute>();
            
            if (logExecutionTimeAttribute != null)
            {
                Console.WriteLine($"Executing method: {method.Name}");

                // Start stopwatch
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Invoke the method
                method.Invoke(taskManager, null);

                // Stop stopwatch
                stopwatch.Stop();

                // Print the execution time
                Console.WriteLine($"Execution Time for {method.Name}: {stopwatch.ElapsedMilliseconds} ms\n");
            }
        }
    }
}


