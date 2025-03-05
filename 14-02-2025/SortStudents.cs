using System;
class BubbleSort
{
    public static void Sort(int[] marks)
    {
        int n = marks.Length;
        for (int i = 0;i < n - 1;i++)
        {
            bool swapped = false;
            for (int j = 0;j < n - i - 1;j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
    public static void Display(int[] marks)
    {
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] studentMarks = { 85, 72, 90, 60, 88, 76, 95, 80 };
        Console.WriteLine("Original Marks:");
        Display(studentMarks);
        Sort(studentMarks);
        Console.WriteLine("Sorted Marks (Ascending Order):");
        Display(studentMarks);
    }
}
