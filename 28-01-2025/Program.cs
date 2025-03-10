using System;

class HandshakeCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        if (numberOfStudents < 2)
        {
            Console.WriteLine("At least two students are required for handshakes.");
            return;
        }
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is: " + handshakes);
    }
}
