using System;

class SimpleInterest
{
    static void Main(string[] args)
    {

        // Variable to take user input for Principal
        Console.Write("Enter the Principal amount (INR): ");
       double principal = Convert.ToDouble(Console.ReadLine());

        // Variable to take user input for Rate of Interest
        Console.Write("Enter the Rate of Interest (%): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Variable to take user input for Time
        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculating Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Results
       Console.WriteLine("The Simple Interest is INR " + simpleInterest + " for Principal INR " + principal + ", Rate of Interest " + rate + "% and Time " + time + " years.");

    }
}
