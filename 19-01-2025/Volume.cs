using System;

class Volume
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of the cylinder: ");
        int radius = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of the cylinder: ");
        int height = int.Parse(Console.ReadLine());
		int volume = (int)(Math.PI * radius * radius * height);
        Console.WriteLine("The volume of the cylinder is: {0}", volume);
    }
}
