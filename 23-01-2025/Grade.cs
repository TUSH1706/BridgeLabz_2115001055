using System;

class Grade
{
    static void Main(string[] args)
    {
        // Taking user input for marks in three subjects
        Console.Write("Enter marks for Physics: ");
        double physicsMarks = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        double chemistryMarks = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        double mathsMarks = Convert.ToDouble(Console.ReadLine());

        
        double totalMarks = physicsMarks + chemistryMarks + mathsMarks;
        double percentage = (totalMarks / 300) * 100; // Total is out of 300

        
        double averageMarks = totalMarks / 3;
        Console.WriteLine("\nTotal Marks: " + totalMarks);
        Console.WriteLine("Percentage: " + percentage + "%");
        Console.WriteLine("Average Marks: " + averageMarks);

        // Grade Calculation
        string grade = "";
        string remarks = "";

        
        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below, but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        // Output the grade and remarks
        Console.WriteLine("\nGrade: " + grade);
        Console.WriteLine("Remarks: " + remarks);
    }
}
