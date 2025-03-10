using System;
using System.IO;

class FileHandling
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fsRead))
            {
                string content = reader.ReadToEnd();
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsWrite))
                {
                    writer.Write(content);
                }
            }

            Console.WriteLine("File copied successfully!");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}