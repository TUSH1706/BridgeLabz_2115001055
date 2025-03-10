using System;

class Perimeter
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the length of the rectangle: ");
        int length = int.Parse(Console.ReadLine());

       
        Console.Write("Enter the width of the rectangle: ");
        int width = int.Parse(Console.ReadLine());

        
        int perimeter = 2 * (length + width);

        Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
    }
}
