using System;
using System.IO;
using System.Text;
class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        try
        {
            ConvertUppercaseToLowercase(inputFilePath, outputFilePath);
            Console.WriteLine("File conversion completed successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
    }
    static void ConvertUppercaseToLowercase(string inputFile, string outputFile)
    {
        using (FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
        using (BufferedStream bufferedInput = new BufferedStream(inputStream))
        using (FileStream outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedOutput = new BufferedStream(outputStream))
        {
            int byteRead;
            while ((byteRead = bufferedInput.ReadByte()) != -1)
            {
                char character = (char)byteRead;
                if (character >= 'A' && character <= 'Z') 
                {
                    character = (char)(character + 32);
                }
                bufferedOutput.WriteByte((byte)character);
            }
        }
    }
}
