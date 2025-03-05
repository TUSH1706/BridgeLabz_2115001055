using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FileReadingComparison
{
    
    static void ReadWithStreamReader(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1) { } 
        }
    }

    
    static void ReadWithFileStream(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096]; 
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }
    static double MeasureExecutionTime(Action<string> method, string filePath)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        method(filePath);
        stopwatch.Stop();
        return (double)stopwatch.ElapsedTicks / Stopwatch.Frequency * 1000; 
    }
    static void Main()
    {
        string filePath = "largefile.bin"; 
        Console.WriteLine("File Size | StreamReader (ms) | FileStream (ms)");
        Console.WriteLine("----------------------------------------------");
        double streamReaderTime = MeasureExecutionTime(ReadWithStreamReader, filePath);
        double fileStreamTime = MeasureExecutionTime(ReadWithFileStream, filePath);
		Console.WriteLine(" 500MB    | {0,15:F4} | {1,12:F4}", streamReaderTime, fileStreamTime);

    }
}
