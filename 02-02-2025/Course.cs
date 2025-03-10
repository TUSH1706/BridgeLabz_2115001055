using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_2025
{
    public class Course
    {
        private string courseName;
        private int duration; 
        private double fee;
        private static string instituteName = "GLA University";

        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration > 0 ? duration : throw new ArgumentException("Duration must be positive.");
            this.fee = fee > 0 ? fee : throw new ArgumentException("Fee must be positive.");
        }

        public string CourseName
        {
            get { return courseName; }
        }

        public int Duration
        {
            get { return duration; }
        }

        public double Fee
        {
            get { return fee; }
        }

        public static string InstituteName
        {
            get { return instituteName; }
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course Details:");
            Console.WriteLine($"Institute: {instituteName}");
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Duration: {Duration} months");
            Console.WriteLine($"Fee: ${Fee:F2}");
        }



        public static void UpdateInstituteName(string newName)
        {
                instituteName = newName;
                Console.WriteLine($"Institute name updated to: {instituteName}");
      
        }


    }
}
