using System;
class QuickSort
{
    public static void QuickSortAlgorithm(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(prices, left, right);
            QuickSortAlgorithm(prices, left, pivotIndex - 1);
            QuickSortAlgorithm(prices, pivotIndex + 1, right);
        }
    }
    public static int Partition(int[] prices, int left, int right)
    {
        int pivot = prices[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (prices[j] < pivot)
            {
                i++;
                int temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }
        int temp1 = prices[i + 1];
        prices[i + 1] = prices[right];
        prices[right] = temp1;

        return i + 1;
    }
    public static void Display(int[] prices)
    {
        for (int i = 0; i < prices.Length; i++)
        {
            Console.Write(prices[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] productPrices = { 599, 199, 799, 349, 999, 499, 150 };

        Console.WriteLine("Original Product Prices:");
        Display(productPrices);
        QuickSortAlgorithm(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted Product Prices (Ascending Order):");
        Display(productPrices);
    }
}
