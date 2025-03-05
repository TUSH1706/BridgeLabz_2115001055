using System;
using System.Diagnostics;

class SearchAndSortComparison
{
    static void Main()
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        Random random = new Random();
        
        foreach (int size in datasetSizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = random.Next(1, size * 10); // Populate with random numbers
            }
            
            int target = data[random.Next(size)]; // Pick a random target
            
            // Linear Search
            Stopwatch stopwatch = Stopwatch.StartNew();
            LinearSearch(data, target);
            stopwatch.Stop();
            Console.WriteLine("Linear Search on " + size + " elements took " + stopwatch.ElapsedMilliseconds + " ms");
            
            // Binary Search (requires sorting first)
            Array.Sort(data);
            stopwatch.Restart();
            BinarySearch(data, target);
            stopwatch.Stop();
            Console.WriteLine("Binary Search on " + size + " elements took " + stopwatch.ElapsedTicks + " ticks\n");
            
            // Sorting Algorithms Comparison
            int[] dataCopy = (int[])data.Clone();
            
            stopwatch.Restart();
            BubbleSort(dataCopy);
            stopwatch.Stop();
            Console.WriteLine("Bubble Sort on " + size + " elements took " + stopwatch.ElapsedMilliseconds + " ms");
            
            dataCopy = (int[])data.Clone();
            stopwatch.Restart();
            MergeSort(dataCopy, 0, dataCopy.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("Merge Sort on " + size + " elements took " + stopwatch.ElapsedMilliseconds + " ms");
            
            dataCopy = (int[])data.Clone();
            stopwatch.Restart();
            QuickSort(dataCopy, 0, dataCopy.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("Quick Sort on " + size + " elements took " + stopwatch.ElapsedMilliseconds + " ms\n");
        }
    }

    static int LinearSearch(int[] data, int target)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == target)
                return i;
        }
        return -1; // Not found
    }

    static int BinarySearch(int[] data, int target)
    {
        int left = 0, right = data.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (data[mid] == target)
                return mid;
            if (data[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1; // Not found
    }

    static void BubbleSort(int[] data)
    {
        int n = data.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (data[j] > data[j + 1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
    }

    static void MergeSort(int[] data, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(data, left, mid);
            MergeSort(data, mid + 1, right);
            Merge(data, left, mid, right);
        }
    }

    static void Merge(int[] data, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        Array.Copy(data, left, L, 0, n1);
        Array.Copy(data, mid + 1, R, 0, n2);
        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
                data[k++] = L[i++];
            else
                data[k++] = R[j++];
        }
        while (i < n1)
            data[k++] = L[i++];
        while (j < n2)
            data[k++] = R[j++];
    }

    static void QuickSort(int[] data, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(data, low, high);
            QuickSort(data, low, pi - 1);
            QuickSort(data, pi + 1, high);
        }
    }

    static int Partition(int[] data, int low, int high)
    {
        int pivot = data[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (data[j] < pivot)
            {
                i++;
                int temp = data[i];
                data[i] = data[j];
                data[j] = temp;
            }
        }
        int swapTemp = data[i + 1];
        data[i + 1] = data[high];
        data[high] = swapTemp;
        return i + 1;
    }
}
