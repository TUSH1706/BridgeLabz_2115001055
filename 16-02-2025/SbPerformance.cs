using System;
using System.Diagnostics;
using System.Text;

class SbPerformance
{
    static void Main()
    {
        Console.Write("Enter the number of iterations: ");
        int iterations;
        while (!int.TryParse(Console.ReadLine(), out iterations) || iterations <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
        }
        Console.Write("Enter the string to concatenate: ");
        string sampleText= Console.ReadLine();
        Stopwatch stopwatch= new Stopwatch();
        stopwatch.Start();
        
        string result= "";
        for (int i = 0; i < iterations; i++)
        {
            result+= sampleText;
        }
        stopwatch.Stop();
        Console.WriteLine("String Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");
        stopwatch.Restart();
        StringBuilder sb= new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append(sampleText);
        }
        string finalResult= sb.ToString();
        stopwatch.Stop();
        Console.WriteLine("StringBuilder Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
