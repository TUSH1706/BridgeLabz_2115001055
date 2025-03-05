using System;
class CountingSort
{
    public static void Sort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }
    public static void Display(int[] ages)
    {
        foreach (int age in ages)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] studentAges = { 12, 15, 10, 14, 18, 13, 16, 12, 15, 17 };
        int minAge = 10, maxAge = 18; // Given age range

        Console.WriteLine("Original Student Ages:");
        Display(studentAges);

        // Sorting using Counting Sort
        Sort(studentAges, minAge, maxAge);

        Console.WriteLine("Sorted Student Ages (Ascending Order):");
        Display(studentAges);
    }
}
