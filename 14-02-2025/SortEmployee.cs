using System;
class InsertionSort
{
    public static void Sort(int[] employeeIDs)
    {
        int n=employeeIDs.Length;
        for (int i=1;i<n;i++)
        {
            int key=employeeIDs[i];
            int j=i - 1;
            while (j>=0 && employeeIDs[j]>key)
            {
                employeeIDs[j + 1]=employeeIDs[j];
                j--;
            }
            employeeIDs[j + 1]=key;
        }
    }
    public static void Display(int[] employeeIDs)
    {
        foreach (int id in employeeIDs)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] employeeIDs={ 1023, 1001, 1054, 1010, 1032, 1005 };

        Console.WriteLine("Original Employee IDs:");
        Display(employeeIDs);
        Sort(employeeIDs);

        Console.WriteLine("Sorted Employee IDs (Ascending Order):");
        Display(employeeIDs);
    }
}
