using System;

class Program
{
    // Method to generate random 2-digit scores for Physics, Chemistry, and Math
    static int[,] GenerateRandomScores(int numStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numStudents, 3]; // Columns: 0 - Physics, 1 - Chemistry, 2 - Math
        
        for (int i = 0; i < numStudents; i++)
        {
            // Generate random 2-digit marks for each subject (between 0 and 99)
            scores[i, 0] = random.Next(0, 100);  // Physics
            scores[i, 1] = random.Next(0, 100);  // Chemistry
            scores[i, 2] = random.Next(0, 100);  // Math
        }

        return scores;
    }

    // Method to calculate total, average, and percentage for each student
    static double[,] CalculateTotalAveragePercentage(int[,] scores, int numStudents)
    {
        double[,] result = new double[numStudents, 4]; // Columns: 0 - Total, 1 - Average, 2 - Percentage
        
        for (int i = 0; i < numStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2]; // Total marks
            double average = total / 3.0; // Average marks
            double percentage = (total / 300.0) * 100; // Percentage
            
            // Round off the values to 2 digits
            result[i, 0] = total;
            result[i, 1] = Math.Round(average, 2);
            result[i, 2] = Math.Round(percentage, 2);
        }

        return result;
    }

    // Method to display the scorecard of all students
    static void DisplayScorecard(int[,] scores, double[,] results, int numStudents)
    {
        Console.WriteLine("\nScorecard of Students:");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Student | Physics | Chemistry | Math | Total | Average | Percentage");
        Console.WriteLine("------------------------------------------------------------");

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{i + 1,7} | {scores[i, 0],7} | {scores[i, 1],9} | {scores[i, 2],4} | {results[i, 0],5} | {results[i, 1],7} | {results[i, 2],10}");
        }

        Console.WriteLine("------------------------------------------------------------");
    }

    static void Main()
    {
        // Input the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Generate random scores for the students
        int[,] scores = GenerateRandomScores(numStudents);

        // Calculate total, average, and percentage for each student
        double[,] results = CalculateTotalAveragePercentage(scores, numStudents);

        // Display the scorecard
        DisplayScorecard(scores, results, numStudents);
    }
}
