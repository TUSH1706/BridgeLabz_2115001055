using System;

class FootballTeamHeights
{
    static void Main(string[] args)
    {
        int[] heights = new int[11];
        GenerateRandomHeights(heights);

        Console.WriteLine("Heights of players (in cms):");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        Console.WriteLine();

        int total = CalculateSum(heights);
        double mean = CalculateMean(total, heights.Length);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("Sum of heights: " + total + " cms");
        Console.WriteLine("Mean height: " + mean + " cms");
        Console.WriteLine("Shortest height: " + shortest + " cms");
        Console.WriteLine("Tallest height: " + tallest + " cms");
    }

    // Generate random heights between 150 and 250 cms
    static void GenerateRandomHeights(int[] heights)
    {
        Random random = new Random();
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251); // Range is 150 to 250 inclusive
        }
    }

    // Calculate the sum of all heights
    static int CalculateSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Calculate the mean height
    static double CalculateMean(int sum, int count)
    {
        return (double)sum / count;
    }

    // Find the shortest height
    static int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    // Find the tallest height
    static int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}
