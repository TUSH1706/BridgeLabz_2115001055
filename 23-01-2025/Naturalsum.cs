using System;

class Naturalsum
{
    static void Main(string[] args)
    {
        //Prompt the user to enter a number
        Console.WriteLine("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        if (n < 0)
        {
            Console.WriteLine("The number " + n + " is not a natural number.");
        }
        else
        {
           
            int formulaSum = n * (n + 1) / 2;
            int loopSum = 0;
            int counter = 0;
            for(int i=1;i<n;i++)
            {
                loopSum += i;
                
            }
            Console.WriteLine("Using formula, the sum of first " + n + " natural numbers is: " + formulaSum);
            Console.WriteLine("Using while loop, the sum of first " + n + " natural numbers is: " + loopSum);

            // results
            if (formulaSum == loopSum)
            {
                Console.WriteLine("Both computations are correct. The results match.");
            }
            else
            {
                Console.WriteLine("The computations do not match. Check the logic.");
            }
        }
    }
}
