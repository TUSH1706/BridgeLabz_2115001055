using System;

public class StudentVote
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false; // Invalid age
        }
        return age >= 18;
    }

    public static void Main()
    {
        int[] studentAges = new int[10]; 
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.WriteLine("Enter age for student" + i + 1);
            if (int.TryParse(Console.ReadLine(), out int age)
            {
                studentAges[i] = age;
                bool canVote = CanStudentVote(age);
                string result = canVote ? "can vote" : "cannot vote";
                Console.WriteLine("Student" +(i + 1)+ " age" +age,+result.);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                i--; 
            }
        }
    }
}
