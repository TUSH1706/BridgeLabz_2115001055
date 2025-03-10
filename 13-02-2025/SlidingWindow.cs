using System;
using System.Collections.Generic;

public class SlidingWindowMaximum
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
        {
            return new int[0];
        }

        int n = nums.Length;
        int[] result = new int[n - k + 1]; // Array to store the maximums
        LinkedList<int> deque = new LinkedList<int>(); // Deque to store indices

        for (int i = 0; i < n; i++)
        {
            // Remove indices of elements that are out of the current window
            while (deque.Count > 0 && deque.First.Value < i - k + 1)
            {
                deque.RemoveFirst();
            }

            // Remove indices of elements that are smaller than the current element
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            {
                deque.RemoveLast();
            }

            // Add the current element's index to the deque
            deque.AddLast(i);

            // If the window has reached size k, add the maximum to the result
            if (i >= k - 1)
            {
                result[i - k + 1] = nums[deque.First.Value];
            }
        }

        return result;
    }

    // Helper function to print the result
    public static void PrintResult(int[] result)
    {
        Console.WriteLine("Sliding Window Maximums:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] result = SlidingWindowMaximum.MaxSlidingWindow(nums, k);

        SlidingWindowMaximum.PrintResult(result);
    }
}