using System;
class Numbers{
	static double CheckNumber(double n){
		if(n>0){
			return 1;
		}
		else if(n<0){
			return -1;
		}
		else{
			return 0;
		}
	}
	static void Main(string [] args){
		double n=Convert.ToInt32(Console.ReadLine());
		double numbers=CheckNumber(n);
		Console.WriteLine(numbers);
	}
}
  