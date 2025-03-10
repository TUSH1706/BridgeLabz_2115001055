using System;
using System.IO;

class HandlingFile
{
    static void Main()
    {
        string filePath = "data.txt";
        
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:\n" + content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
        }
    }
}
