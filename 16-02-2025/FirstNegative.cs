using System;

class FirstNegative
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());        
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int firstNegative = FindFirstNegative(arr);
        if (firstNegative != int.MaxValue)
            Console.WriteLine("The first negative number in the array is: " + firstNegative);
        else
            Console.WriteLine("No negative number found in the array.");
    }
    static int FindFirstNegative(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
                return arr[i];
        }
        return int.MaxValue;
    }
}
