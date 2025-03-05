using System;

class ChocolateDivision
{
    static void Main(string[] args)
    {

        // Variable to take user input for the number of chocolates
        Console.Write("Enter the total number of chocolates: ");
         int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        // Variable to take user input for the number of children
        Console.Write("Enter the number of children: ");
       int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculating the chocolates each child gets and the remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Results
        Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild);
        Console.WriteLine("The number of remaining chocolates is " + remainingChocolates);
    }
}
