using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        //Prompt the user to enter salary
        Console.Write("Enter the employee's salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        //Prompt the user to enter years of service
        Console.Write("Enter the employee's years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        // Checking if the employee is eligible for a bonus
        if (yearsOfService > 5)
        {
            // Calculate the bonus (5% of the salary)
            double bonus = salary * 0.05;
            Console.WriteLine("The employee is eligible for a bonus of: " + bonus);
        }
        else
        {
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}
