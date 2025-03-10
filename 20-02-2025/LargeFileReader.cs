using System;
using System.IO;
using System.Text;

class LargeFileReader
{
    static void Main()
    {
        string filePath = "largefile.txt"; 

        try
        {
            ReadLargeFile(filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
    }

    static void ReadLargeFile(string filePath)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            StringBuilder currentLine = new StringBuilder();
            int byteRead;

            while ((byteRead = fileStream.ReadByte()) != -1) 
            {
                char character = (char)byteRead;

                if (character == '\n') 
                {
                    ProcessLine(currentLine.ToString());
                    currentLine.Clear();
                }
                else if (character != '\r') 
                {
                    currentLine.Append(character);
                }
            }
            if (currentLine.Length > 0)
            {
                ProcessLine(currentLine.ToString());
            }
        }
    }

    static void ProcessLine(string line)
    {
        if (ContainsError(line))
        {
            Console.WriteLine(line);
        }
    }
    static bool ContainsError(string line)
    {
        int len = line.Length;
        for (int i = 0; i < len - 4; i++)
        {
            if (CharToLower(line[i]) == 'e' &&
                CharToLower(line[i + 1]) == 'r' &&
                CharToLower(line[i + 2]) == 'r' &&
                CharToLower(line[i + 3]) == 'o' &&
                CharToLower(line[i + 4]) == 'r')
            {
                return true;
            }
        }
        return false;
    }
    static char CharToLower(char c)
    {
        return (c >= 'A' && c <= 'Z') ? (char)(c + 32) : c; 
    }
}
