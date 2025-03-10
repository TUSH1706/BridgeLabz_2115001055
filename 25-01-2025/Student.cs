using System;

class Students
{
    static void Main(string [] args)
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Initialize a 2D array for storing marks
        int[,] marks = new int[numStudents, 3]; // Rows = students, Columns = subjects (Physics, Chemistry, Maths)
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        // Input marks
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nEnter marks for Student {0}:", i + 1);
            marks[i, 0] = GetValidMarks("Physics");
            marks[i, 1] = GetValidMarks("Chemistry");
            marks[i, 2] = GetValidMarks("Maths");
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = totalMarks / 3.0;
            grades[i] = CalculateGrade(percentages[i]);
        }
        Console.WriteLine("\nStudent Results:");
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}",
            "Student", "Physics", "Chemistry", "Maths", "%age", "Grade");\

        // Print Data
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10:F2}{5,-10}",
                i + 1, marks[i, 0], marks[i, 1], marks[i, 2], percentages[i], grades[i]);
        }
    }

    static int GetValidMarks(string subject)
    {
        int marks;
        while (true)
        {
            Console.Write("Enter marks in {0}: ", subject);
            marks = int.Parse(Console.ReadLine());
            if (marks >= 0)
                break;
            Console.WriteLine("Marks cannot be negative. Please enter again.");
        }
        return marks;
    }
    static char CalculateGrade(double percentage)
    {
        if (percentage >= 80)
            return 'A';
        else if (percentage >= 70)
            return 'B';
        else if (percentage >= 60)
            return 'C';
        else if (percentage >= 50)
            return 'D';
        else if (percentage >= 40)
            return 'E';
        else
            return 'R';
    }
}
