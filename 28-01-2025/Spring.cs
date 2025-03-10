using System;
class Spring{
	static string CheckSpring(double month,double day){
		 if ((month == 3 && day >= 20 && day <= 31) ||(month == 4 && day >= 1 && day <= 30) ||(month == 5 && day >= 1 && day <= 31) ||(month == 6 && day >= 1 && day <= 20))     
        {
           return "It's a Spring Season";
        }
        else
        {
            return "Not a Spring Season";
		}
	}
	static void Main(string[] args){
		double month=Convert.ToInt32(Console.ReadLine());
		double day=Convert.ToInt32(Console.ReadLine());
		string season= CheckSpring(day,month);
		Console.WriteLine(season);
	}
}