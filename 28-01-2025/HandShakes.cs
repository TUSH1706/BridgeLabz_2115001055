using System;

class Handshakes
{
    static void Main(string[] args)
    {
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        int handshake = numberOfStudents * (numberOfStudents - 1) / 2;
        Console.WriteLine("Number of possible handshakes: " + handshake);
    }
}