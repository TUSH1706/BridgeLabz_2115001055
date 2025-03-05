using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolandStudentswithCourses_AssociationandAggregation
{
    public class School
    {
        public string name;
        private List<Student> students;

        public School(string name)
        {
            this.name = name;
            students = new List<Student>();
        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void showStudents()
        {
            Console.WriteLine($"School: {name}");
            foreach (var student in students)
            {
                student.viewCourses();
            }
        }
    }

    public class Student
    {
        public string name;
        private List<Course> courses;

        public Student(string name)
        {
            this.name = name;
            courses = new List<Course>();
        }

        public void enrollCourse(Course course)
        {
            courses.Add(course);
            course.addStudent(this);
        }

        public void viewCourses()
        {
            Console.WriteLine($"Student: {name} is enrolled in:");
            foreach (var course in courses)
            {
                Console.WriteLine($"  Course: {course.name}");
            }
        }
    }

    public class Course
    {
        public string name;
        private List<Student> students;

        public Course(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void showStudents()
        {
            Console.WriteLine($"Course: {name} has the following students:");
            foreach (var student in students)
            {
                Console.WriteLine($"  Student: {student.name}");
            }
        }

    }
}
