using System;

class MatrixOperations
{
    // Method to create a random matrix
    static int[,] CreateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10); // Random numbers between 1 and 9
            }
        }

        return matrix;
    }

    // Method to display a matrix
    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Method to add two matrices
    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        
        int[,] result = new int[rows, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // Method to subtract two matrices
    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        
        int[,] result = new int[rows, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    // Method to multiply two matrices
    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix2.GetLength(1);
        int common = matrix1.GetLength(1);
        
        int[,] result = new int[rows, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < common; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    // Method to find the transpose of a matrix
    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        int[,] result = new int[cols, rows];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }

    // Method to find the determinant of a 2x2 matrix
    static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Method to find the determinant of a 3x3 matrix
    static int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
               matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
               matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    // Method to find the inverse of a 2x2 matrix
    static double[,] Inverse2x2(int[,] matrix)
    {
        int determinant = Determinant2x2(matrix);
        if (determinant == 0)
        {
            throw new InvalidOperationException("Matrix is not invertible.");
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = (double)matrix[1, 1] / determinant;
        inverse[0, 1] = (double)-matrix[0, 1] / determinant;
        inverse[1, 0] = (double)-matrix[1, 0] / determinant;
        inverse[1, 1] = (double)matrix[0, 0] / determinant;

        return inverse;
    }

    // Method to find the inverse of a 3x3 matrix
    static double[,] Inverse3x3(int[,] matrix)
    {
        int determinant = Determinant3x3(matrix);
        if (determinant == 0)
        {
            throw new InvalidOperationException("Matrix is not invertible.");
        }

        double[,] inverse = new double[3, 3];
        inverse[0, 0] = (double)(matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / determinant;
        inverse[0, 1] = (double)(matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / determinant;
        inverse[0, 2] = (double)(matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / determinant;
        inverse[1, 0] = (double)(matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / determinant;
        inverse[1, 1] = (double)(matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / determinant;
        inverse[1, 2] = (double)(matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / determinant;
        inverse[2, 0] = (double)(matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / determinant;
        inverse[2, 1] = (double)(matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / determinant;
        inverse[2, 2] = (double)(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / determinant;

        return inverse;
    }

    static void Main()
    {
        int rows = 3;
        int cols = 3;

        // Generate random matrices
        int[,] matrix1 = CreateRandomMatrix(rows, cols);
        int[,] matrix2 = CreateRandomMatrix(rows, cols);

        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);
        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);

        // Matrix Addition
        int[,] sumMatrix = AddMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix Addition:");
        DisplayMatrix(sumMatrix);

        // Matrix Subtraction
        int[,] diffMatrix = SubtractMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix Subtraction:");
        DisplayMatrix(diffMatrix);

        // Matrix Multiplication
        int[,] productMatrix = MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix Multiplication:");
        DisplayMatrix(productMatrix);

        // Matrix Transpose
        int[,] transposeMatrix1 = TransposeMatrix(matrix1);
        Console.WriteLine("Transpose of Matrix 1:");
        DisplayMatrix(transposeMatrix1);

        // Determinant of a 3x3 matrix
        int determinant3x3 = Determinant3x3(matrix1);
        Console.WriteLine("Determinant of Matrix 1 (3x3): " + determinant3x3);

        // Inverse of a 3x3 matrix
        try
        {
            double[,] inverseMatrix1 = Inverse3x3(matrix1);
            Console.WriteLine("Inverse of Matrix 1 (3x3):");
            DisplayMatrix(inverseMatrix1);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
