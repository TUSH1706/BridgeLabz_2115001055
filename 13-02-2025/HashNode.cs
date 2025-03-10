using System;
using System.Collections.Generic;

public class HashNode<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }
    public HashNode<K, V> Next { get; set; }

    public HashNode(K key, V value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

public class CustomHashMap<K, V>
{
    private readonly int _capacity;
    private readonly LinkedList<HashNode<K, V>>[] _buckets;
    
    public CustomHashMap(int capacity = 10)
    {
        _capacity = capacity;
        _buckets = new LinkedList<HashNode<K, V>>[_capacity];
    }

    private int GetBucketIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % _capacity;
    }

    public void Insert(K key, V value)
    {
        int index = GetBucketIndex(key);
        if (_buckets[index] == null)
            _buckets[index] = new LinkedList<HashNode<K, V>>();

        foreach (var node in _buckets[index])
        {
            if (node.Key.Equals(key))
            {
                node.Value = value;
                return;
            }
        }

        _buckets[index].AddLast(new HashNode<K, V>(key, value));
    }

    public V Get(K key)
    {
        int index = GetBucketIndex(key);
        if (_buckets[index] == null)
            throw new KeyNotFoundException("Key not found");

        foreach (var node in _buckets[index])
        {
            if (node.Key.Equals(key))
                return node.Value;
        }

        throw new KeyNotFoundException("Key not found");
    }

    public bool Remove(K key)
    {
        int index = GetBucketIndex(key);
        if (_buckets[index] == null)
            return false;

        var node = _buckets[index].First;
        while (node != null)
        {
            if (node.Value.Key.Equals(key))
            {
                _buckets[index].Remove(node);
                return true;
            }
            node = node.Next;
        }
        return false;
    }
}

public class Program
{
    public static void Main()
    {
        CustomHashMap<string, int> map = new CustomHashMap<string, int>();
        map.Insert("one", 1);
        map.Insert("two", 2);
        map.Insert("three", 3);

        Console.WriteLine("Value for key 'two': " + map.Get("two"));
        
        map.Remove("two");
        Console.WriteLine("Key 'two' removed.");
        
        try
        {
            Console.WriteLine(map.Get("two"));
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
