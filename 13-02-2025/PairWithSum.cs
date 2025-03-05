using System;
using System.Collections.Generic;

public class PairWithSum
{
    public static bool HasPairWithSum(int[] arr, int targetSum)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in arr)
        {
            int difference = targetSum - num;
            if (seenNumbers.Contains(difference))
            {
                return true; // Pair found
            }
            seenNumbers.Add(num);
        }

        return false;
    }
    public static void PrintResult(bool result)
    {
        if (result)
        {
            Console.WriteLine("Pair with the given sum exists.");
        }
        else
        {
            Console.WriteLine("No pair with the given sum exists.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        int[] arr = { 1, 4, 45, 6, 10, 8 };
        int targetSum = 16;

        bool result = PairWithSum.HasPairWithSum(arr, targetSum);
        PairWithSum.PrintResult(result);
    }
}