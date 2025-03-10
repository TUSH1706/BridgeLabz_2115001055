using System;

class TotalPrice{
    static void Main(string[] args)
    {

        // Variable to take user input for unit price of the item
        Console.Write("Enter the unit price of the item (INR): ");
       double unitPrice = Convert.ToDouble(Console.ReadLine());  // Read and convert the input to double

        // Variable to take user input the quantity to be bought
        Console.Write("Enter the quantity to be bought: ");
        double quantity = Convert.ToInt32(Console.ReadLine());  // Read and convert the input to integer

        // Calculating the total purchase price
        double totalPrice = unitPrice * quantity;

        //Result
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
    }
}
