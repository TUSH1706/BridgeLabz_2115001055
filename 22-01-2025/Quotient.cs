using System;

class Quotient
{
    static void Main(string[] args){
		

        // Variable to take input the first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        //Variable to take user input the second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine()); 

        // Calculating the quotient
        int quotient = number1 / number2;

        // Calculating the remainder
        int remainder = number1 % number2;

        // Display the results
        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
    }
}
