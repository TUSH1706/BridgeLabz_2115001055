using System;
using System.IO;
class Program
{
    static void Main()
    {
        string originalImagePath = "input.jpg"; 
        string newImagePath = "output.jpg";

        try
        {
            byte[] imageBytes = FileToByteArray(originalImagePath);
            ByteArrayToFile(newImagePath, imageBytes);
            if (VerifyFiles(originalImagePath, newImagePath))
            {
                Console.WriteLine("Success: The files are identical.");
            }
            else
            {
                Console.WriteLine("Error: The files are different.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
    }
    static byte[] FileToByteArray(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            long length = fs.Length;
            byte[] buffer = new byte[length];
            int bytesRead = 0, totalBytesRead = 0;

            while (totalBytesRead < length)
            {
                bytesRead = fs.Read(buffer, totalBytesRead, (int)(length - totalBytesRead));
                totalBytesRead += bytesRead;
            }
            return buffer;
        }
    }
    static void ByteArrayToFile(string filePath, byte[] byteArray)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            int bytesWritten = 0;
            while (bytesWritten < byteArray.Length)
            {
                fs.Write(byteArray, bytesWritten, byteArray.Length - bytesWritten);
                bytesWritten += (byteArray.Length - bytesWritten);
            }
        }
    }
    static bool VerifyFiles(string file1, string file2)
    {
        using (FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read))
        using (FileStream fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read))
        {
            if (fs1.Length != fs2.Length) return false;

            int byte1, byte2;
            do
            {
                byte1 = fs1.ReadByte();
                byte2 = fs2.ReadByte();
                if (byte1 != byte2) return false;
            }
            while (byte1 != -1 && byte2 != -1);

            return true;
        }
    }
}
