
using System;
using System.Reflection;

public class Person
{
    private int age;

    public Person(int age)
    {
        this.age = age;
    }
}

public class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

public class ReflectionExample
{
    // 1. Get Class Information: Methods, Fields, and Constructors
    public static void DisplayClassInfo(string className)
    {
        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine($"Class {className} not found!");
            return;
        }

        Console.WriteLine($"Class: {type.Name}");

        // Display Methods
        Console.WriteLine("\nMethods:");
        foreach (var method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        // Display Fields
        Console.WriteLine("\nFields:");
        foreach (var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
        {
            Console.WriteLine(field.Name);
        }

        // Display Constructors
        Console.WriteLine("\nConstructors:");
        foreach (var constructor in type.GetConstructors())
        {
            Console.WriteLine(constructor.ToString());
        }
    }

    // 2. Access Private Field using Reflection
    public static void ModifyAndRetrievePrivateField()
    {
        Person person = new Person(25);
        Type type = typeof(Person);

        // Access private field 'age'
        FieldInfo ageField = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        // Retrieve and display private field value
        int ageValue = (int)ageField.GetValue(person);
        Console.WriteLine($"Original age (private field): {ageValue}");

        // Modify the private field value
        ageField.SetValue(person, 30);
        ageValue = (int)ageField.GetValue(person);
        Console.WriteLine($"Updated age (private field): {ageValue}");
    }

    // 3. Invoke Private Method using Reflection
    public static void InvokePrivateMethod()
    {
        Calculator calculator = new Calculator();
        Type type = typeof(Calculator);

        // Access private method 'Multiply'
        MethodInfo multiplyMethod = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        // Invoke the method with parameters (3, 5)
        int result = (int)multiplyMethod.Invoke(calculator, new object[] { 3, 5 });
        Console.WriteLine($"Result of Multiply(3, 5): {result}");
    }

    // 4. Dynamically Create Objects using Reflection
    public static void CreateStudentInstanceDynamically()
    {
        Type type = typeof(Student);

        // Create an instance of Student dynamically using reflection (without using 'new')
        ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string) });
        object studentInstance = constructor.Invoke(new object[] { "John Doe" });

        // Access and display the Name property of the Student object
        PropertyInfo nameProperty = type.GetProperty("Name");
        string name = (string)nameProperty.GetValue(studentInstance);
        Console.WriteLine($"Dynamically created Student Name: {name}");
    }

    public static void Main(string[] args)
    {
        // 1. Get Class Information
        Console.WriteLine("1. Class Information:");
        DisplayClassInfo("Person");

        // 2. Access Private Field
        Console.WriteLine("\n2. Access Private Field:");
        ModifyAndRetrievePrivateField();

        // 3. Invoke Private Method
        Console.WriteLine("\n3. Invoke Private Method:");
        InvokePrivateMethod();

        // 4. Dynamically Create Objects
        Console.WriteLine("\n4. Dynamically Create Objects:");
        CreateStudentInstanceDynamically();
    }
}

