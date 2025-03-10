
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

public class MathOperations
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;
}

public class Configuration
{
    private static string API_KEY = "initial_key";
}

public class ReflectionExample
{
    // 1. Dynamic Method Invocation
    public static void InvokeMethodDynamically()
    {
        MathOperations mathOps = new MathOperations();
        Type type = typeof(MathOperations);

        Console.WriteLine("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        Console.WriteLine("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        MethodInfo method = type.GetMethod(methodName);

        if (method != null)
        {
            var result = method.Invoke(mathOps, new object[] { a, b });
            Console.WriteLine($"Result of {methodName}: {result}");
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }

    // 2. Retrieve Attributes at Runtime
    public static void RetrieveAttributes()
    {
        Type type = typeof(MyClassWithAuthor);

        // Get the AuthorAttribute applied to the class
        AuthorAttribute authorAttribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        if (authorAttribute != null)
        {
            Console.WriteLine($"Author of {type.Name}: {authorAttribute.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }

    // 3. Access and Modify Static Fields
    public static void ModifyStaticField()
    {
        Type type = typeof(Configuration);

        // Access the private static field API_KEY
        FieldInfo fieldInfo = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (fieldInfo != null)
        {
            // Modify the static field value
            fieldInfo.SetValue(null, "new_api_key_123");

            // Retrieve and print the updated value
            var newApiKey = (string)fieldInfo.GetValue(null);
            Console.WriteLine($"Updated API_KEY: {newApiKey}");
        }
        else
        {
            Console.WriteLine("Field not found.");
        }
    }

    public static void Main(string[] args)
    {
        // 1. Dynamic Method Invocation
        Console.WriteLine("1. Dynamic Method Invocation:");
        InvokeMethodDynamically();

        // 2. Retrieve Attributes at Runtime
        Console.WriteLine("\n2. Retrieve Attributes at Runtime:");
        RetrieveAttributes();

        // 3. Access and Modify Static Fields
        Console.WriteLine("\n3. Access and Modify Static Fields:");
        ModifyStaticField();
    }
}

[Author("John Doe")]
public class MyClassWithAuthor
{
    // This class is just for demonstration purposes and has the Author attribute applied.
}


