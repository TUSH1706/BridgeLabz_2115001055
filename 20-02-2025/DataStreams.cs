using System;
using System.IO;

class DataStreams
{
    static void Main()
    {
        string filePath = "students.dat";
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(101); 
                writer.Write("Alice Johnson"); 
                writer.Write(3.8); // GPA
                
                writer.Write(102);
                writer.Write("Bob Smith");
                writer.Write(3.6);
            }
            Console.WriteLine("Student details stored successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    int rollNumber = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();
                    
                    Console.WriteLine($"Roll No: {rollNumber}, Name: {name}, GPA: {gpa}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
    }
}
