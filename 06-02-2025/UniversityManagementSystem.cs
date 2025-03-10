using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    public class Cour
    {
        public string name;
        private List<Stu> students;
        public Professor professor;

        public Cour(string name)
        {
            this.name = name;
            students = new List<Stu>();
        }

        public void assignProfessor(Professor professor)
        {
            this.professor = professor;
            Console.WriteLine($"Professor {professor.name} is assigned to teach {name}.");
        }

        public void enrollStudent(Stu student)
        {
            students.Add(student);
            student.enrollCourse(this);
            Console.WriteLine($"Student {student.name} has enrolled in {name}.");
        }

        public void showEnrolledStudents()
        {
            Console.WriteLine($"Course: {name} has the following students enrolled:");
            foreach (var student in students)
            {
                Console.WriteLine($"  Student: {student.name}");
            }
        }

    }

    public class Professor
    {
        public string name;

        public Professor(string name)
        {
            this.name = name;
        }

        public void assignCourse(Cour course)
        {
            course.assignProfessor(this);
        }

    }

    public class Stu
    {
        public string name;
        private List<Cour> courses;

        public Stu(string name)
        {
            this.name = name;
            courses = new List<Cour>();
        }
        public void enrollCourse(Cour course)
        {
            courses.Add(course);
        }

        public void showCourses()
        {
            Console.WriteLine($"Student: {name} is enrolled in the following courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"  Course: {course.name}");
            }
        }


    }
}
