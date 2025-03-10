using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_2025
{
    public class Student
    {
        public int RollNumber { get; set; }

        protected string Name { get; set; }

        private double CGPA;

        public Student(int rollNumber, string name, double cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            CGPA = cgpa;
        }

        public void SetCGPA(double cgpa)
        {
            if (cgpa >= 0.0 && cgpa <= 10.0)
            {
                CGPA = cgpa;
            }
            else
            {
                Console.WriteLine("Invalid CGPA. It should be between 0.0 and 10.0.");
            }
        }

        public double GetCGPA()
        {
            return CGPA;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}, CGPA: {CGPA}");
        }
    }


    public class PostgraduateStudent : Student
    {
        private string ResearchTopic;


        public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
            : base(rollNumber, name, cgpa)
        {
            ResearchTopic = researchTopic;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}, Research Topic: {ResearchTopic}, CGPA: {GetCGPA()}");
        }
    }
}
