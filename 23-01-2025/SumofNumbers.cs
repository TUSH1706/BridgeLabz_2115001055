using System;

class SumNumbers
{
    static void Main(string[] args)
    {
        double total = 0.0;
        

       // Prompt the user to enter a number
         Console.WriteLine("Enter numbers to sum. Enter 0 to stop:");

            while (true)
      {
            Console.Write("Enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

           
            if (userInput == 0)
            {
                
                Console.WriteLine("The total sum is: " + total);
                return;
            }

            
            total += userInput;
        }
    }
}
