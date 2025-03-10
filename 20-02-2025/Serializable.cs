using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

[Serializable]
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}
class EmployeeSerialization
{
    static void Main()
    {
        string filePath = "employees.json";
        List<Employee> employees = new List<Employee>();

        try
        {
            Console.WriteLine("Enter the number of employees: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter details for Employee " + (i + 1) + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Department: ");
                string department = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employees.Add(new Employee { Id = id, Name = name, Department = department, Salary = salary });
            }
            string jsonData = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employees data saved successfully.");
            string readData = File.ReadAllText(filePath);
            List<Employee> deserializedEmployees = JsonSerializer.Deserialize<List<Employee>>(readData);

            Console.WriteLine("\nRetrieved Employee Data:");
            foreach (var emp in deserializedEmployees)
            {
                Console.WriteLine("ID: " + emp.Id + ", Name: " + emp.Name + ", Department: " + emp.Department + ", Salary: " + emp.Salary);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
