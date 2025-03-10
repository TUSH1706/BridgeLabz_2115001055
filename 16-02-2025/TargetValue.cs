using System;
class TargetValue
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter the elements of the matrix (row-wise sorted):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.Write("Enter the target value to search: ");
        int target = int.Parse(Console.ReadLine());
        (int row, int col) = SearchMatrix(matrix, rows, cols, target);
        if (row != -1)
            Console.WriteLine("nTarget " +target+  "found at position: " + row, col);
        else
            Console.WriteLine($"\nTarget {target} not found in the matrix.");
    }
    static (int, int) SearchMatrix(int[,] matrix, int rows, int cols, int target)
    {
        int left = 0, right = rows * cols - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols, mid % cols];
            if (midValue == target)
                return (mid / cols, mid % cols);
            if (midValue < target)
                left = mid + 1; 
            else
                right = mid - 1;
        }
        return (-1, -1);
    }
}
