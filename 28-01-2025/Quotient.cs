using System;
class Program{
public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }
	static void Main(string[] args)
    {
        Console.Write("Enter the dividend: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(number, divisor);

        Console.WriteLine("The quotient is: " + result[0]);
        Console.WriteLine("The remainder is: " + result[1]);
    }
}
	
