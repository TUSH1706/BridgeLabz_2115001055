using System;
class HeapSort
{
    public static void Sort(int[] salaries)
    {
        int n = salaries.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }
        for (int i = n - 1; i > 0; i--)
        {
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;
            Heapify(salaries, i, 0);
        }
    }
    public static void Heapify(int[] salaries, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1; 
        int right = 2 * i + 2; 
        if (left < n && salaries[left] > salaries[largest])
        {
            largest = left;
        }
        if (right < n && salaries[right] > salaries[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            int temp = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = temp;

            Heapify(salaries, n, largest);
        }
    }
    public static void Display(int[] salaries)
    {
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] salaryDemands = { 50000, 75000, 60000, 85000, 40000, 95000, 70000 };
        Console.WriteLine("Original Salary Demands:");
        Display(salaryDemands);
        Sort(salaryDemands);
        Console.WriteLine("Sorted Salary Demands (Ascending Order):");
        Display(salaryDemands);
    }
}
