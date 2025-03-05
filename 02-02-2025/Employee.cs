using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_2025
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        protected string Department { get; set; }

        private double Salary;

        public Employee(int employeeID, string department, double salary)
        {
            EmployeeID = employeeID;
            Department = department;
            Salary = salary;
        }

        public void SetSalary(double newSalary)
        {
            if (newSalary > 0)
            {
                Salary = newSalary;
                Console.WriteLine($"Salary updated to {Salary}");
            }
            else
            {
                Console.WriteLine("Invalid salary amount.");
            }
        }
        public double GetSalary()
        {
            return Salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Department: {Department}, Salary: {Salary}");
        }

    }

    public class Manager : Employee
    {
        private string role; 


        public Manager(int employeeID, string department, double salary, string role)
            : base(employeeID, department, salary)
        {
            SetRole(role);
        }

        public void SetRole(string newRole)
        {
            if (!string.IsNullOrWhiteSpace(newRole))
            {
                role = newRole;
            }
            else
            {
                Console.WriteLine("Invalid role.");
            }
        }

        public string GetRole()
        {
            return role;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Department: {Department}, Role: {role}, Salary: {GetSalary()}");
        }
    }
}
