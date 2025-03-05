using System;
using System.Collections.Generic;

public class ZeroSumSubarrays
{
    public static List<List<int>> FindZeroSumSubarrays(int[] arr)
    {
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == 0)
                {
                    List<int> subarray = new List<int>();
                    for (int k = i; k <= j; k++)
                    {
                        subarray.Add(arr[k]);
                    }
                    result.Add(subarray);
                }
            }
        }

        return result;
    }
    public static void PrintResult(List<List<int>> result)
    {
        Console.WriteLine("Subarrays with zero sum:");
        foreach (var subarray in result)
        {
            Console.WriteLine($"[{string.Join(", ", subarray)}]");
        }
    }
}

public class Program
{
    public static void Main()
    {
        int[] arr = { 4, 2, -3, -1, 0, 4 };
        List<List<int>> result = ZeroSumSubarrays.FindZeroSumSubarrays(arr);

        ZeroSumSubarrays.PrintResult(result);
    }
}