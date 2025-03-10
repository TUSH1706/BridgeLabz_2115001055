using System;
class FirstMissingLinear
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
}
