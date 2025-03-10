using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMAnagementSystem
{
    public class Employee
    {
        public string name;
        public int id;
        public double salary;

        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, ID: {id}, Salary: {salary}");
        }
    }

    class Manager: Employee
    {
        public int teamSize;

        public Manager(string name, int id, int salary, int teamSize) : base(name, id, salary)
        {
            this.teamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Team size: {teamSize}");
        }
    }

    class Developer: Employee
    {
        public string programmingLanguage;

        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Known Programming Language: {programmingLanguage}");
        }

    }

    class Intern: Employee
    {
        public string internshipDuration;
        public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
        {
            this.internshipDuration = internshipDuration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Internship Duration: {internshipDuration}");
        }
    }
}
