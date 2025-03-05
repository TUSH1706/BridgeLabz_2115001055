using System;
class MergeSort
{
    public static void Sort(int[] prices, int left, int right)
    {
        if (left<right)
        {
            int middle=(left + right)/2;
            Sort(prices, left, middle);
            Sort(prices, middle + 1, right);
            Merge(prices, left, middle, right);
        }
    }
    public static void Merge(int[] prices, int left, int middle, int right)
    {
        int n1=middle-left+1;
        int n2=right - middle;
        int[] leftArray=new int[n1];
        int[] rightArray=new int[n2];
        for (inti=0;i<n1;i++)
            leftArray[i] = prices[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[middle + 1 + j];
        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                prices[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                prices[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }
        while (iIndex < n1)
        {
            prices[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }
        while (jIndex < n2)
        {
            prices[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }
    public static void Display(int[] prices)
    {
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] bookPrices = { 450, 120, 999, 320, 250, 680, 150 };

        Console.WriteLine("Original Book
