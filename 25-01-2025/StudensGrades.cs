using System;

class StudentGrades
{
    static void Main(string [] args)
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());
        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nEnter marks for Student {0}:", i + 1);           
            physicsMarks[i] = GetValidMarks("Physics");
            chemistryMarks[i] = GetValidMarks("Chemistry");
            mathsMarks[i] = GetValidMarks("Maths");

            int totalMarks = physicsMarks[i] + chemistryMarks[i] + mathsMarks[i];
            percentages[i] = totalMarks / 3.0;

            grades[i] = CalculateGrade(percentages[i]);
        }
        Console.WriteLine("\nStudent Results:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\t%age\tGrade");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4:F2}\t{5}", 
                i + 1, physicsMarks[i], chemistryMarks[i], mathsMarks[i], percentages[i], grades[i]);
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
        if (percentage >= 90)
            return 'A';
        else if (percentage >= 75)
            return 'B';
        else if (percentage >= 50)
            return 'C';
        else if (percentage >= 35)
            return 'D';
        else
            return 'F';
    }
}
