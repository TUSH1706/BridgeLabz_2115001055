using System;
using System.Collections.Generic;

abstract class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public Employee(int employeeId, string name, double baseSalary)
    {
        EmployeeId = employeeId;
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Base Salary: {BaseSalary}");
    }
}

class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int employeeId, string name, double baseSalary) 
        : base(employeeId, name, baseSalary) { }

    public override double CalculateSalary()
    {
        // Assuming a fixed monthly salary
        return BaseSalary;
    }
}

class PartTimeEmployee : Employee
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public PartTimeEmployee(int employeeId, string name, double baseSalary, double hourlyRate, int hoursWorked) 
        : base(employeeId, name, baseSalary)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        // Salary based on hours worked and hourly rate
        return HoursWorked * HourlyRate;
    }
}

interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

class EmployeeManager : IDepartment
{
    private List<Employee> employees = new List<Employee>();
    private string department;

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void DisplayAllEmployeeDetails()
    {
        foreach (var employee in employees)
        {
            employee.DisplayDetails();
            Console.WriteLine($"Calculated Salary: {employee.CalculateSalary()}");
            Console.WriteLine();
        }
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {department}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager();

        manager.AssignDepartment("IT Department");

        FullTimeEmployee ftEmployee = new FullTimeEmployee(1, "Alice", 50000);
        PartTimeEmployee ptEmployee = new PartTimeEmployee(2, "Bob", 0, 20, 100);

        manager.AddEmployee(ftEmployee);
        manager.AddEmployee(ptEmployee);

        manager.DisplayAllEmployeeDetails();

        Console.WriteLine(manager.GetDepartmentDetails());
    }
}
