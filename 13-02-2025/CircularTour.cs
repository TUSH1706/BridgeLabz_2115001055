using System;
using System.Collections.Generic;

public class CircularTour
{
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        int start = 0;
        int surplus = 0;
        int totalSurplus = 0;

        for (int i = 0; i < n; i++)
        {
            surplus += petrol[i] - distance[i];
            if (surplus < 0)
            {
                start = i + 1;
                surplus = 0;
            }
            totalSurplus += petrol[i] - distance[i];
        }
        return (totalSurplus >= 0) ? start : -1;
    }
    public static void PrintResult(int start)
    {
        if (start == -1)
        {
            Console.WriteLine("No possible starting point for a circular tour.");
        }
        else
        {
            Console.WriteLine("Start from petrol pump " +start+ "to complete the circular tour.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int start = CircularTour.FindStartingPoint(petrol, distance);
        CircularTour.PrintResult(start);
    }
}