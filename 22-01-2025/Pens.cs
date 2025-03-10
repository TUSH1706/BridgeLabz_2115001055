using System;

class Pens
{
    static void Main(string[] args)
    {
        // Variable for total number of pens and number of students
        int totalPens = 14;
        int totalStudents = 3;

        // Calculating pens each student will get
        int pensPerStudent = totalPens / totalStudents;

        // Calculating the remaining non-distributed pens
        int remainingPens = totalPens % totalStudents;

        // Results
        Console.WriteLine("The Pen Per Student is " + pensPerStudent + " and the remaining pen not distributed is " + remainingPens);
    }
}
