using System;
using System.Collections.Generic;
public abstract class CourseType
{
    public string CourseName { get; set; }
    public string Department { get; set; }

    public abstract void Evaluate();
}
public class ExamCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine("Evaluating " + CourseName + " in " + Department + " through an exam.");
    }
}
public class AssignmentCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine("Evaluating " + CourseName + " in " + Department + " through assignments.");
    }
}
public class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();
    public void AddCourse(T course)
    {
        courses.Add(course);
        Console.WriteLine("Added course: " + course.CourseName + " in " + course.Department);
    }
    public void EvaluateAllCourses()
    {
        foreach (var course in courses)
        {
            course.Evaluate();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var examCourse1 = new ExamCourse { CourseName = "Mathematics", Department = "Science" };
        var examCourse2 = new ExamCourse { CourseName = "Physics", Department = "Science" };
        var assignmentCourse1 = new AssignmentCourse { CourseName = "Literature", Department = "Arts" };
        var assignmentCourse2 = new AssignmentCourse { CourseName = "History", Department = "Arts" };
        var examCourseManager = new Course<ExamCourse>();
        examCourseManager.AddCourse(examCourse1);
        examCourseManager.AddCourse(examCourse2);
        var assignmentCourseManager = new Course<AssignmentCourse>();
        assignmentCourseManager.AddCourse(assignmentCourse1);
        assignmentCourseManager.AddCourse(assignmentCourse2);
        Console.WriteLine("\nEvaluating Exam Courses:");
        examCourseManager.EvaluateAllCourses();

        Console.WriteLine("\nEvaluating Assignment Courses:");
        assignmentCourseManager.EvaluateAllCourses();
    }
}