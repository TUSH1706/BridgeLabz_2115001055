using System;
using System.Collections.Generic;

public class LongestConsecutiveSequence
{
    public static int FindLongestConsecutiveSequence(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> numSet = new HashSet<int>(nums);
        int maxLength = 0;

        foreach (int num in nums)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentLength = 1;
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentLength++;
                }
                maxLength = Math.Max(maxLength, currentLength);
            }
        }

        return maxLength;
    }
    public static void PrintResult(int result)
    {
        Console.WriteLine("Length of the longest consecutive sequence: " +result);
    }
}

public class Program
{
    public static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        int result = LongestConsecutiveSequence.FindLongestConsecutiveSequence(nums);

        LongestConsecutiveSequence.PrintResult(result);
    }
}