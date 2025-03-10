using System;

class FriendDetails
{
    static void Main(string[] args)
    {
        // Input: Age and Height of Amar
        Console.Write("Enter age of Amar: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height of Amar (in cm): ");
        int amarHeight = Convert.ToInt32(Console.ReadLine());

        // Input: Age and Height of Akbar
        Console.Write("Enter age of Akbar: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height of Akbar (in cm): ");
        int akbarHeight = Convert.ToInt32(Console.ReadLine());

        // Input: Age and Height of Anthony
        Console.Write("Enter age of Anthony: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height of Anthony (in cm): ");
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());

        
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        if (youngestAge == amarAge) Console.WriteLine("The youngest friend is Amar.");
        else if (youngestAge == akbarAge) Console.WriteLine("The youngest friend is Akbar.");
        else Console.WriteLine("The youngest friend is Anthony.");

        
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        if (tallestHeight == amarHeight) Console.WriteLine("The tallest friend is Amar.");
        else if (tallestHeight == akbarHeight) Console.WriteLine("The tallest friend is Akbar.");
        else Console.WriteLine("The tallest friend is Anthony.");
    }
}
