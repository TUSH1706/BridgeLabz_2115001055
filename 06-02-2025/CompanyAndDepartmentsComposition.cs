using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAndDepartmentsComposition
{
    public class Company 
    {
        public string name;
        private List<Department> dept;
        public Company(string name)
        {
            this.name = name;
            dept = new List<Department>();
        }
        public void addDepartment(string deptName)
        {
            dept.Add(new Department(deptName));
        }

        public void showDepartments()
        {
            Console.WriteLine($"Company: {name}");

            foreach(var d in dept)
            {
                d.showEmployees();
            }
        }
    }

    public class Department
    {
        public string name;
        private List<Employee> employees;

        public Department(string name)
        {
            this.name = name;
            employees = new List<Employee>();
        }
        public void addEmployee(string employeeName)
        {
            employees.Add(new Employee(employeeName));
        }

        public void showEmployees()
        {
            Console.WriteLine($"Department: {name}");
            foreach (var emp in employees)
            {
                Console.WriteLine($"  Employee: {emp.name}");
            }
        }
    }

    class Employee
    {
        public string name;

        public Employee(string name)
        {
            this.name = name;
        }
    }
}
