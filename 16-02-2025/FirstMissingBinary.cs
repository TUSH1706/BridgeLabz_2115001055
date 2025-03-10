using System;

class FirstMissingBinary
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the list: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the list:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int missingPositive = FindFirstMissingPositive(arr);
        Console.WriteLine("First missing positive integer: " + missingPositive);
        BubbleSort(arr);
        Console.Write("Enter the target number to find: ");
        int target = int.Parse(Console.ReadLine());
        int index = BinarySearch(arr, target);
        if (index != -1)
            Console.WriteLine("Target "+target+ " found at index: " +index);
        else
            Console.WriteLine($"Target " +target+  "not found in the list.");
    }
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= 0 || arr[i] > n)
            {
                arr[i] = n + 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            int num = Math.Abs(arr[i]);
            if (num <= n && arr[num - 1] > 0)
            {
                arr[num - 1] = -arr[num - 1];
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                return i + 1;
            }
        }
        return n + 1;
    }
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
