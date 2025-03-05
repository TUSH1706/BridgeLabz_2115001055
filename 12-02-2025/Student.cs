using System;

class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public string Grade;
    public StudentNode Next;

    public StudentNode(int rollNumber, string name, int age, string grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head;

    public void AddStudent(int rollNumber, string name, int age, string grade, int? position = null)
    {
        StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
        if (position == null || position == 0)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            StudentNode temp = head;
            int count = 0;
            while (temp != null && count < position - 1)
            {
                temp = temp.Next;
                count++;
            }
            if (temp == null)
            {
                Console.WriteLine("Invalid position! Adding at the end.");
            }
            newNode.Next = temp?.Next;
            if (temp != null)
            {
                temp.Next = newNode;
            }
        }
    }

    public void DeleteStudent(int rollNumber)
    {
        StudentNode temp = head, prev = null;
        while (temp != null && temp.RollNumber != rollNumber)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }
        if (prev == null)
        {
            head = temp.Next;
        }
        else
        {
            prev.Next = temp.Next;
        }
        Console.WriteLine("Student deleted successfully.");
    }

    public StudentNode SearchStudent(int rollNumber)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateGrade(int rollNumber, string newGrade)
    {
        StudentNode student = SearchStudent(rollNumber);
        if (student != null)
        {
            student.Grade = newGrade;
            Console.WriteLine("Grade updated successfully.");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    public void DisplayStudents()
    {
        StudentNode temp = head;
        if (temp == null)
        {
            Console.WriteLine("No student records found.");
            return;
        }
        while (temp != null)
        {
            Console.WriteLine("Roll Number:" +temp.RollNumber," Name: " +temp.Name, "Age:" +temp.Age, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList students = new StudentLinkedList();
        students.AddStudent(1, "Aditya", 20, "A");
        students.AddStudent(2, "Ram", 21, "B", position: 1);
        students.AddStudent(3, "Shyam", 22, "C", position: 2);
        students.DisplayStudents();
        students.UpdateGrade(2, "A+");
        students.DisplayStudents();
        students.DeleteStudent(1);
        students.DisplayStudents();
    }
}
