using System;
class FirstLastOccurence
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the sorted array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the sorted array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the target element to find: ");
        int target = int.Parse(Console.ReadLine());
        int firstOccurrence = FindOccurrence(arr, target, true);
        int lastOccurrence = FindOccurrence(arr, target, false);
        if (firstOccurrence != -1)
        {
            Console.WriteLine("First occurrence of " +target+ " is at index: " +firstOccurrence);
            Console.WriteLine("Last occurrence of " + target+ " is at index: " +lastOccurrence);
        }
        else
        {
            Console.WriteLine("Element " +target+ " not found in the array.");
        }
    }
    static int FindOccurrence(int[] arr, int target, bool findFirst)
    {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                if (findFirst)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1; 
            }
        }
        return result;
    }
}
