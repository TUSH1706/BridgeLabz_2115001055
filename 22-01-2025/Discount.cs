using System;

class Discount
{
    static void Main(string[] args)
    {
        // Variable for original course fee and discount percentage
        double fee = 125000;
        double discountPercent = 10;

        // Calculating the discount amount
        double discount = (fee * discountPercent) / 100;

        // Calculating the final discounted fee
        double finalFee = fee - discount;

        // Results
        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
    }
}
