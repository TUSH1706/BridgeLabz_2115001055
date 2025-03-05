using System;

class Compare
{
    static int CompareStrings(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
                return -1;
            else if (str1[i] > str2[i])
                return 1;         }
        if (str1.Length < str2.Length)
            return -1;
        else if (str1.Length > str2.Length)
            return 1;
        else
            return 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = CompareStrings(str1, str2);

        if (result < 0)
            Console.WriteLine(str1 + " comes before " +str2 + " in lexicographical order.");
        else if (result > 0)
            Console.WriteLine(str1 + " comes after " + str2 + "in lexicographical order.");
        else
            Console.WriteLine(str1 + " and " +str2+ " are equal.");
    }
}
