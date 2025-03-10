using System;

class Power
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base: ");
        int baseNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        int exponent = int.Parse(Console.ReadLine());
        int result = (int)Math.Pow(baseNum, exponent);
		Console.WriteLine("{0} raised to the power of {1} is {2}", baseNum, exponent, result);
    }
}
