using System;

class HandShakes
{
    static void Main(string[] args)
    {
        // Variable to take user nput the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculating the maximum number of handshakes
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Result
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + maxHandshakes);
    }
}
