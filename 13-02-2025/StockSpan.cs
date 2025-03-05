using System;
using System.Collections.Generic;

public class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] spans = new int[n];
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[i] >= prices[stack.Peek()])
            {
                stack.Pop();
            }
            spans[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }

        return spans;
    }
    public static void PrintSpans(int[] spans)
    {
        Console.WriteLine("Stock Spans:");
        for (int i = 0; i < spans.Length; i++)
        {
            Console.WriteLine("Day {i}: " +spans[i]);
        }
    }
}

public class Program
{
    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] spans = StockSpan.CalculateSpan(prices);

        StockSpan.PrintSpans(spans);
    }
}