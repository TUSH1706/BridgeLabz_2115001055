using System;
using System.IO;

class ReadWrite
{
    static void Main()
    {
        Console.Write("Enter the file path to save input: ");
        string filePath = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.WriteLine("Enter text to write to the file (Type 'STOP' to finish):");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.ToUpper() == "STOP")
                        break;

                    writer.WriteLine(input);
                }
            }
            Console.WriteLine("\nUser input successfully written to the file!");
            Console.WriteLine("\nReading file content...");
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
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
