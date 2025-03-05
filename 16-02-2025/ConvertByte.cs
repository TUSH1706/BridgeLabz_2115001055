using System;
using System.IO;

class ConverByte
{
    static void Main()
    {
        Console.Write("Enter the full path of the binary file: ");
        string filePath = Console.ReadLine();
        if (!FileExists(filePath)) 
        {
            Console.WriteLine("File not found. Please enter a valid file path.");
            return;
        }
        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int byteData;                
                Console.WriteLine("\nFile Content:");
                while ((byteData = fileStream.ReadByte()) != -1)
                {
                    char character = ByteToChar(byteData);
                    Console.Write(character);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }
    }
    static bool FileExists(string path)
    {
        try
        {
            return new FileInfo(path).Exists;
        }
        catch
        {
            return false;
        }
    }
    static char ByteToChar(int byteValue)
    {
        if (byteValue >= 32 && byteValue <= 126)
            return (char)byteValue;
        return ' '; 
    }
}
