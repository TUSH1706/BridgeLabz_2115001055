using System;

class Marks
{
    static void Main(string[] args)
    {
        // Variable for marks in individual subjects
        int mathsMark = 94;
        int physicsMark = 95;
        int chemistryMark = 96;

        // Total possible marks
        int totalMarks = 300;

        // Calculating the sum of marks obtained by Sam
        int obtainedMarks = mathsMark + physicsMark + chemistryMark;

        // Calculating the average percentage
        float averagePercentage = (float)obtainedMarks/totalMarks*100;

        //Result
        Console.WriteLine("Sam’s average mark in PCM is " + averagePercentage + "%");
    }
}
