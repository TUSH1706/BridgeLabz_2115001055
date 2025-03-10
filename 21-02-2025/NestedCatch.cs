using System;

class Nested
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int divisor = 0;
        try
        {
            int index = 2;
            int element = array[index];
            
            try
            {
                int result = element / divisor;
                Console.WriteLine("The result of division is: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}
