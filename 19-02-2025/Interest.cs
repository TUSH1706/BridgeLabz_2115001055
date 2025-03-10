Qusing System;

class Interest
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the Principal amount: ");
        int principal = int.Parse(Console.ReadLine());

        
        Console.Write("Enter the Rate of interest: ");
        int rate = int.Parse(Console.ReadLine());

       
        Console.Write("Enter the Time period in years: ");
        int time = int.Parse(Console.ReadLine());

        
        int simpleInterest = (principal * rate * time) / 100;

        
        Console.WriteLine("The Simple Interest is: {0}", simpleInterest);
    }
}
