using System;

class Average
{
    static void Main(string[] args)
    {
       
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

 
        int average = (num1 + num2 + num3) / 3;

        Console.WriteLine("The average of the three numbers is: {0}", average);
    }
}
