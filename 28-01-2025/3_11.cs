using System;

class Program
{
    // Method to determine the salary and years of service using Math.Random()
    static double[,] GetEmployeeData(int numEmployees)
    {
        Random random = new Random();
        double[,] data = new double[numEmployees, 2]; // 0: Salary, 1: Years of Service
        
        for (int i = 0; i < numEmployees; i++)
        {
            // Generate a random 5-digit salary between 10000 and 99999
            data[i, 0] = random.Next(10000, 100000);
            // Generate a random years of service between 1 and 20 years
            data[i, 1] = random.Next(1, 21);
        }

        return data;
    }

    // Method to calculate the new salary and bonus based on years of service
    static double[,] CalculateNewSalaryAndBonus(double[,] data, int numEmployees)
    {
        double[,] newSalaryAndBonus = new double[numEmployees, 3]; // 0: New Salary, 1: Bonus, 2: Old Salary
        
        for (int i = 0; i < numEmployees; i++)
        {
            double oldSalary = data[i, 0];
            int yearsOfService = (int)data[i, 1];
            double bonus = 0;

            // Determine bonus based on years of service
            if (yearsOfService > 5)
            {
                bonus = oldSalary * 0.05; // 5% bonus
            }
            else
            {
                bonus = oldSalary * 0.02; // 2% bonus
            }

            // Calculate new salary (Old salary + Bonus)
            double newSalary = oldSalary + bonus;

            // Store the values
            newSalaryAndBonus[i, 0] = newSalary;
            newSalaryAndBonus[i, 1] = bonus;
            newSalaryAndBonus[i, 2] = oldSalary;
        }

        return newSalaryAndBonus;
    }

    // Method to calculate the sum of the old salary, new salary, and total bonus
    static void CalculateAndDisplayTotals(double[,] oldAndNewSalaries, int numEmployees)
    {
        double sumOldSalary = 0;
        double sumNewSalary = 0;
        double totalBonus = 0;

        // Calculate the sum of old salaries, new salaries, and total bonus
        for (int i = 0; i < numEmployees; i++)
        {
            sumOldSalary += oldAndNewSalaries[i, 2]; // Old Salary
            sumNewSalary += oldAndNewSalaries[i, 0]; // New Salary
            totalBonus += oldAndNewSalaries[i, 1];   // Bonus
        }

        // Display in tabular format
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("| Employee | Old Salary | New Salary | Bonus |");
        Console.WriteLine("----------------------------------------------------");
        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine($"| {i + 1,8} | {oldAndNewSalaries[i, 2],10:C} | {oldAndNewSalaries[i, 0],10:C} | {oldAndNewSalaries[i, 1],6:C} |");
        }
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Total Old Salary: {sumOldSalary:C}");
        Console.WriteLine($"Total New Salary: {sumNewSalary:C}");
        Console.WriteLine($"Total Bonus: {totalBonus:C}");
    }

    static void Main()
    {
        int numEmployees = 10; // Zara has 10 employees
        double[,] employeeData = GetEmployeeData(numEmployees); // Get random employee data
        double[,] updatedSalariesAndBonuses = CalculateNewSalaryAndBonus(employeeData, numEmployees); // Calculate new salary and bonus
        
        CalculateAndDisplayTotals(updatedSalariesAndBonuses, numEmployees); // Calculate and display totals
    }
}
