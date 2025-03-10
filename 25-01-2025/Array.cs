using System;

class Array
{
    static void Main(string [] args)
    {
        // Take user input for rows and columns
        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());    
        Console.WriteLine("Enter the number of columns:");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element at [{i}, {j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Create a 1D array to copy the elements of the matrix
        int[] array = new int[rows * columns];
        
        // Define the index variable for 1D array
        int index = 0;

        // Loop through the 2D array and copy its elements to the 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++; // Increment the index
            }
        }

        // Display the 1D array
        Console.WriteLine("The 1D array is:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
