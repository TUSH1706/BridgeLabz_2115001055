using System;

class Profit
{
    static void Main(string[] args)
    {
        // Variables for the cost price and selling price
        double costPrice = 129;
        double sellingPrice = 191;

        // Calculating profit
        double profit = sellingPrice - costPrice;

        // Calculating profit percentage
        double profitPercentage = (profit / costPrice) * 100;

        //Result
        Console.WriteLine(
            "The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice + "\n" +
            "The Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage
        );
    }
}
