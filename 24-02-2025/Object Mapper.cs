
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Diagnostics;

#region 1. Custom Object Mapper

public static class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
    {
        T obj = (T)Activator.CreateInstance(clazz);

        foreach (var property in properties)
        {
            var propertyInfo = clazz.GetProperty(property.Key);
            if (propertyInfo != null && propertyInfo.CanWrite)
            {
                propertyInfo.SetValue(obj, property.Value);
            }
        }

        return obj;
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

#endregion

#region 2. Generate a JSON Representation

public static class JsonGenerator
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        StringBuilder sb = new StringBuilder();
        sb.Append("{");

        foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            sb.Append($"\"{field.Name}\": \"{field.GetValue(obj)}\", ");
        }

        // Remove last comma and space
        if (sb.Length > 1)
            sb.Length -= 2;

        sb.Append("}");
        return sb.ToString();
    }
}

public class Student
{
    public string Name { get; set; }
    private int age;

    public Student(string name, int age)
    {
        Name = name;
        this.age = age;
    }

    private int GetAge() => age;
}

#endregion

#region 3. Custom Logging Proxy Using Reflection

public interface IGreeting
{
    void SayHello();
}

public class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }
}

public class LoggingProxy<T> : DispatchProxy
{
    private T _decorated;

    public static T Create(T decorated)
    {
        object proxy = Create<T, LoggingProxy<T>>();
        ((LoggingProxy<T>)proxy)._decorated = decorated;
        return (T)proxy;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine($"Method {targetMethod.Name} is being called.");
        var result = targetMethod.Invoke(_decorated, args);
        Console.WriteLine($"Method {targetMethod.Name} finished execution.");
        return result;
    }
}

#endregion

#region 4. Dependency Injection Using Reflection

[AttributeUsage(AttributeTargets.Property, Inherited = false)]
public class InjectAttribute : Attribute { }

public class Container
{
    private Dictionary<Type, object> _instances = new Dictionary<Type, object>();

    public void Register<T>(T instance)
    {
        _instances[typeof(T)] = instance;
    }

    public T Resolve<T>()
    {
        Type type = typeof(T);
        var constructor = type.GetConstructors().First();
        var parameters = constructor.GetParameters();
        var arguments = parameters.Select(p => Resolve(p.ParameterType)).ToArray();
        return (T)constructor.Invoke(arguments);
    }

    public object Resolve(Type type)
    {
        if (_instances.ContainsKey(type))
        {
            return _instances[type];
        }

        var constructor = type.GetConstructors().First();
        var parameters = constructor.GetParameters();
        var arguments = parameters.Select(p => Resolve(p.ParameterType)).ToArray();
        return constructor.Invoke(arguments);
    }
}

public class ServiceA { }

public class ServiceB
{
    [Inject]
    public ServiceA ServiceA { get; set; }

    public ServiceB() { }
}

#endregion

#region 5. Method Execution Timing

public static class MethodTiming
{
    public static void MeasureExecutionTime(object obj, string methodName)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found.");
            return;
        }

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        method.Invoke(obj, null);

        stopwatch.Stop();
        Console.WriteLine($"Execution time of {methodName}: {stopwatch.ElapsedMilliseconds} ms");
    }
}

public class Calculator
{
    public void Add(int a, int b)
    {
        System.Threading.Thread.Sleep(1000); // Simulating computation
        Console.WriteLine($"Addition result: {a + b}");
    }
}

#endregion

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Custom Object Mapper
        Console.WriteLine("1. Custom Object Mapper:");
        var properties = new Dictionary<string, object> { { "Name", "John" }, { "Age", 30 } };
        Person person = ObjectMapper.ToObject<Person>(typeof(Person), properties);
        Console.WriteLine($"Mapped Object - Name: {person.Name}, Age: {person.Age}");

        // 2. Generate a JSON Representation
        Console.WriteLine("\n2. Generate a JSON Representation:");
        Student student = new Student("Jane", 22);
        Console.WriteLine(JsonGenerator.ToJson(student));

        // 3. Custom Logging Proxy Using Reflection
        Console.WriteLine("\n3. Custom Logging Proxy Using Reflection:");
        IGreeting greeting = new Greeting();
        IGreeting proxy = LoggingProxy<IGreeting>.Create(greeting);
        proxy.SayHello();

        // 4. Dependency Injection Using Reflection
        Console.WriteLine("\n4. Dependency Injection Using Reflection:");
        Container container = new Container();
        container.Register(new ServiceA());
        ServiceB serviceB = container.Resolve<ServiceB>();
        Console.WriteLine($"ServiceA injected into ServiceB: {serviceB.ServiceA != null}");

        // 5. Method Execution Timing
        Console.WriteLine("\n5. Method Execution Timing:");
        Calculator calculator = new Calculator();
        MethodTiming.MeasureExecutionTime(calculator, "Add");
    }
}



