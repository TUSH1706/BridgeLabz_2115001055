using System;

class Employee
{
    static void Main(string[] args)
    {
        const int EmployeeCount = 10;
        double[] salaries = new double[EmployeeCount];
        double[] yearsOfService = new double[EmployeeCount];
        double[] bonuses = new double[EmployeeCount];
        double[] newSalaries = new double[EmployeeCount];

        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;
        
        for (int i = 0; i < EmployeeCount; i++)
        {
            Console.WriteLine("Enter details for Employee " + (i + 1) + ":");
            while (true)
            {
                Console.Write("Enter salary: ");
                double salary;
                if (double.TryParse(Console.ReadLine(), out salary) && salary > 0)
                {
                    salaries[i] = salary;
                    break;
                }
                Console.WriteLine("Invalid salary. Please enter a positive number.");
            }
            while (true)
            {
                Console.Write("Enter years of service: ");
                double years;
                if (double.TryParse(Console.ReadLine(), out years) && years >= 0)
                {
                    yearsOfService[i] = years;
                    break;
                }
                Console.WriteLine("Invalid years of service. Please enter a non-negative number.");
            }
        }
        for (int i = 0; i < EmployeeCount; i++)
        {
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        // Output results
        Console.WriteLine("\nSummary:");
        Console.WriteLine("Total bonus payout: " + totalBonus.ToString("F2"));
        Console.WriteLine("Total old salary: " + totalOldSalary.ToString("F2"));
        Console.WriteLine("Total new salary: " + totalNewSalary.ToString("F2"));

        Console.WriteLine("\nEmployee Details:");
        for (int i = 0; i < EmployeeCount; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + ": Old Salary = " + salaries[i].ToString("F2") + ", Years of Service = " + yearsOfService[i] + ", Bonus = " + bonuses[i].ToString("F2") + ", New Salary = " + newSalaries[i].ToString("F2"));
        }
    }
}
