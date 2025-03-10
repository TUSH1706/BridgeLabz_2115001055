using System;

class Area
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle: ");
        int radius = int.Parse(Console.ReadLine());
        int area = (int)(Math.PI * radius * radius);
        Console.WriteLine("The area of the circle is: {0}", area);
    }
}
