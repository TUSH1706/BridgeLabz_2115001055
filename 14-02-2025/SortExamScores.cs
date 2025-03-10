using System;
class SelectionSort
{
    public static void Sort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }
    }
    public static void Display(int[] scores)
    {
        foreach (int score in scores)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        int[] examScores = { 78, 92, 85, 66, 90, 73, 88 };
        Console.WriteLine("Original Exam Scores:");
        Display(examScores);
        Sort(examScores);
        Console.WriteLine("Sorted Exam Scores (Ascending Order):");
        Display(examScores);
    }
}
