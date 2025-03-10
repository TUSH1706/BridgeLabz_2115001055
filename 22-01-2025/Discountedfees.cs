using System;

class Discountedfees
{
    static void Main(string[] args)
    {

        // Variable to takeuser input for the fee
        Console.Write("Enter the fee amount: ");
        double fee = Convert.ToDouble(Console.ReadLine()); 

        // Variable to take user input for the discount percentage
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculating the discount amount
        double discount = (fee * discountPercent) / 100;

        // Calculating the final fee after discount
        double finalFee = fee - discount;

        // Results
        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
    }
}
