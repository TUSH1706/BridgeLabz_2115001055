using System;

class Heights
{
    static void Main(string[] args)
    {
        // Declaring arrays to store the names, ages, and heights
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height (in meters) of " + names[i] + ": ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Finding the youngest friend
        int youngestAge = Math.Min(ages[0], Math.Min(ages[1], ages[2]));
        int youngestIndex = Array.IndexOf(ages, youngestAge);
        string youngestFriend = names[youngestIndex];

        // Finding the tallest friend
        double tallestHeight = Math.Max(heights[0], Math.Max(heights[1], heights[2]));
        int tallestIndex = Array.IndexOf(heights, tallestHeight);
        string tallestFriend = names[tallestIndex];
        Console.WriteLine("The youngest friend is " + youngestFriend + " with age " + youngestAge + ".");
        Console.WriteLine("The tallest friend is " + tallestFriend + " with height " + tallestHeight + " meters.");
    }
}
