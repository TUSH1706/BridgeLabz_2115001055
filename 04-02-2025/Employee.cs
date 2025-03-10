using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public static string CompanyName = "Capgemini";
        private static int totalEmployees = 0;

        public readonly int Id;
        private string name;
        private string designation;

        public Employee(string name, int id, string designation)
        {
            this.name = name;
            this.Id = id;
            this.designation = designation;
            totalEmployees++;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployees}");
        }

        // Method to get employee details
        public string GetEmployeeDetails()
        {
            return $"ID: {Id}\nName: {name}\nDesignation: {designation}";
        }
        public static void DisplayEmployeeDetails(object obj)
        {
            if (obj is Employee emp)
            {
                Console.WriteLine(emp.GetEmployeeDetails());
            }
            else
            {
                Console.WriteLine("The object is not an Employee.");
            }
        }
    }
}
