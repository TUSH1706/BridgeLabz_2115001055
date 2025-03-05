using System;

class GCD
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static int LCM(int a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        // Calculate GCD and LCM
        int gcdResult = GCD(num1, num2);
        int lcmResult = LCM(num1, num2);
        
        Console.WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + gcdResult);
        Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcmResult);
    }
}
