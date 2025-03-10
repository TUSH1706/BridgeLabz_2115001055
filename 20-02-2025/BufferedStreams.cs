using System;
using System.Diagnostics;
using System.IO;

class FileCopyPerformance
{
    static void Main()
    {
        string sourceFile = "largefile.dat";
        string destinationFileBuffered = "copy_buffered.dat";
        string destinationFileUnbuffered = "copy_unbuffered.dat";
        int bufferSize = 4096; // 4 KB buffer size

        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Error: Source file does not exist.");
            return;
        }

        Stopwatch stopwatch = new Stopwatch();

        // Buffered Copy without using BufferedStream
        stopwatch.Start();
        using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destinationFileBuffered, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[bufferSize];
            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                for (int i = 0; i < bytesRead; i++)
                {
                    fsWrite.WriteByte(buffer[i]);
                }
            }
        }
        stopwatch.Stop();
        Console.WriteLine("Buffered Copy (Manual) Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Unbuffered Copy
        stopwatch.Restart();
        using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destinationFileUnbuffered, FileMode.Create, FileAccess.Write))
        {
            int singleByte;
            while ((singleByte = fsRead.ReadByte()) != -1)
            {
                fsWrite.WriteByte((byte)singleByte);
            }
        }
        stopwatch.Stop();
        Console.WriteLine("Unbuffered Copy Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
