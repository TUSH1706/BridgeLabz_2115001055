using System;

class Propagation
{
    static void Method1()
    {
        int result = 10 / 0;
    }

    static void Method2()
    {
        Method1();
    }

    static void Main(string[] args)
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
