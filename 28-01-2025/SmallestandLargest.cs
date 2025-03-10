using System;

class SmallestAndLargest
{
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(Math.Min(number1, number2), number3);
        int largest = Math.Max(Math.Max(number1, number2), number3);
        
        return new int[] { smallest, largest };
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(num1, num2, num3);
        Console.WriteLine("Smallest number: " + result[0]);
        Console.WriteLine("Largest number: " + result[1]);
    }
}
