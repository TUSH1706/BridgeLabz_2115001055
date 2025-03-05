using System;
class Interest{
	static double SimpleInterest(double principle, double rate, double time)

	{
		return (principle*rate*time)/100;
	}
	static void Main(string[] args){
		Console.WriteLine("Enter the Principsl :");
		double principle=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the rate :");
		double rate=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the time :");
		double time=Convert.ToDouble(Console.ReadLine());
		double interest=SimpleInterest(principle,rate,time);
		Console.WriteLine(interest);
	}
}

		
		
		
		
		
	