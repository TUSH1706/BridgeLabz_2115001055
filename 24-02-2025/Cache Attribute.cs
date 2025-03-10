
using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class CacheResultAttribute : Attribute
{
}

public class CacheManager
{
    // Dictionary to store cached results, using method parameters as the key
    private static Dictionary<string, object> cache = new Dictionary<string, object>();

    public static bool TryGetCache(string key, out object value)
    {
        return cache.TryGetValue(key, out value);
    }

    public static void AddCache(string key, object value)
    {
        cache[key] = value;
    }
}

public class MathOperations
{
    // A method to demonstrate caching for computationally expensive operations
    [CacheResult]
    public int ExpensiveComputation(int x, int y)
    {
        // Generate a unique cache key based on method parameters
        string cacheKey = $"{nameof(ExpensiveComputation)}_{x}_{y}";

        // Check if the result is already cached
        if (CacheManager.TryGetCache(cacheKey, out object cachedValue))
        {
            Console.WriteLine("Cache hit! Returning cached result.");
            return (int)cachedValue;
        }

        // If not cached, perform the expensive computation (simulate a delay)
        Console.WriteLine("Cache miss! Performing computation...");
        int result = x * y + 42;  // Simulating a computationally expensive operation

        // Add the result to the cache
        CacheManager.AddCache(cacheKey, result);

        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MathOperations mathOps = new MathOperations();

        // First call with the same parameters - cache miss, will compute the result
        Console.WriteLine("Result: " + mathOps.ExpensiveComputation(5, 10));

        // Second call with the same parameters - cache hit, will return the cached result
        Console.WriteLine("Result: " + mathOps.ExpensiveComputation(5, 10));

        // Call with different parameters - cache miss, will compute the result
        Console.WriteLine("Result: " + mathOps.ExpensiveComputation(7, 14));
    }
}



