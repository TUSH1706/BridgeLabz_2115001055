using System;
using System.IO;
using System.Text;
using System.Threading;
class PipedStreamExample
{
    static readonly MemoryStream pipeStream = new MemoryStream(); 
    static readonly object lockObject = new object(); 
    static void Main()
    {
        Thread writerThread = new Thread(WriteToPipe);
        Thread readerThread = new Thread(ReadFromPipe);

        writerThread.Start();
        readerThread.Start();

        writerThread.Join();
        readerThread.Join();
    }
    static void WriteToPipe()
    {
        string message = "Hello, this is inter-thread communication!";
        byte[] messageBytes = Encoding.ASCII.GetBytes(message);

        lock (lockObject)
        {
            try
            {
                foreach (byte b in messageBytes)
                {
                    pipeStream.WriteByte(b); 
                }
                pipeStream.WriteByte(0); // End signal (null character)
                Console.WriteLine("[Writer] Data written to pipe.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("[Writer] IO Exception: " + ex.Message);
            }
        }
    }
    static void ReadFromPipe()
    {
        lock (lockObject)
        {
            try
            {
                pipeStream.Position = 0; 
                byte b;
                StringBuilder sb = new StringBuilder();

                while ((b = (byte)pipeStream.ReadByte()) != 0) 
                {
                    sb.Append((char)b);
                }
                Console.WriteLine("[Reader] Data read from pipe: " + sb.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine("[Reader] IO Exception: " + ex.Message);
            }
        }
    }
}
