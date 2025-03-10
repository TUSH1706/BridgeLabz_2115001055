using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the full path of the text file: ");
        string filePath = Console.ReadLine();
        if (File.Exists(filePath))
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("File not found. Please check the file path.");
        }
    }
}
