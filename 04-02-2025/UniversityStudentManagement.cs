using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentManagement
{
    public class Student
    {
        public static string UniversityName = "GLAU University"; // Static variable shared across all students
        private static int studentCount = 0; // Static variable to track total students

        public readonly int RollNumber; // Readonly RollNumber, cannot be changed after assignment
        private string name;
        private string grade;

        public Student(string name, string grade)
        {
            this.RollNumber = ++studentCount; // Assign a unique RollNumber
            this.name = name;
            this.grade = grade;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students Enrolled: {studentCount}");
        }

        // Method to display student details
        public string GetStudentDetails()
        {
            return $"Roll Number: {RollNumber}\nName: {name}\nGrade: {grade}";
        }

        public void UpdateGrade(string newGrade)
        {
            this.grade = newGrade;
            Console.WriteLine($"Grade updated for {name} (Roll Number: {RollNumber})");
        }

        public static void DisplayStudentDetails(object obj)
        {
            if (obj is Student student)
            {
                Console.WriteLine(student.GetStudentDetails());
            }
            else
            {
                Console.WriteLine("The object is not a Student.");
            }
        }
    }
}
