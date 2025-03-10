using System;

class TotalIncome
{
    static void Main(string[] args)
    {
        
       

        // Variable to take user input for salary and bonus
        Console.Write("Enter the salary (in INR): ");
       double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the bonus (in INR): ");
       double bonus = Convert.ToDouble(Console.ReadLine());

        // Computing total income
        double totalIncome = salary + bonus;

        //Result
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence, Total Income is INR " + totalIncome);
    }
}
