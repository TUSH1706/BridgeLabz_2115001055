using System;

class NumberAnalysis
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Number"+(i + 1));
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.Write("Number" +numbers[i]+ "is Positive and ");
                if (IsEven(numbers[i]))
                {
                    Console.WriteLine("Even.");
                }
                else
                {
                    Console.WriteLine("Odd.");
                }
            }
            else
            {
                Console.WriteLine("Number" +numbers[i] + " is Negative.");
            }
        }
        int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);
        Console.Write("\nComparison of the first and last elements: ");
        if (comparisonResult == 1)
        {
            Console.WriteLine("First element is greater than the last element.");
        }
        else if (comparisonResult == 0)
        {
            Console.WriteLine("First and last elements are equal.");
        }
        else
        {
            Console.WriteLine("First element is less than the last element.");
        }
    }
    static bool IsPositive(int number)
    {
        return number >= 0;
    }
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    static int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            return 1;
        }
        else if (number1 == number2)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
}
