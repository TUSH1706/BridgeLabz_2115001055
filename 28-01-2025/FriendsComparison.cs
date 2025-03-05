using System;

class FriendsComparison
{
    static void Main()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Get input for age and height for each friend
        for (int i = 0; i < friends.Length; i++)
        {
            Console.WriteLine("Enter age for" +friends[i]);
            while (!int.TryParse(Console.ReadLine(), out ages[i]) || ages[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid age for" +friends[i]);
            }

            Console.WriteLine("Enter height (in cm) for" +friends[i]);
            while (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid height for " +friends[i]);
            }
        }

        string youngestFriend = FindYoungest(friends, ages);
        string tallestFriend = FindTallest(friends, heights);

        Console.WriteLine(youngestFriend + "is the youngest among the friends.");
        Console.WriteLine(tallestFriend + "is the tallest among the friends.");
    }

    static string FindYoungest(string[] friends, int[] ages)
    {
        int minAgeIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[minAgeIndex])
            {
                minAgeIndex = i;
            }
        }
        return friends[minAgeIndex];
    }

    static string FindTallest(string[] friends, double[] heights)
    {
        int maxHeightIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[maxHeightIndex])
            {
                maxHeightIndex = i;
            }
        }
        return friends[maxHeightIndex];
    }
}
