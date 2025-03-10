using System;
class Triangle{
	static int distance( int side1,int side2,int side3,int totaldistance){
		 int perimeter=side1+side2+side3;
		return(totaldistance/perimeter);
	}
	static void Main(string[] args){
		int side1=Convert.ToInt32(Console.ReadLine());
		int side2=Convert.ToInt32(Console.ReadLine());
		int side3=Convert.ToInt32(Console.ReadLine());
		int totaldistance=5000;
		int rounds=distance(side1,side2,side3,totaldistance);
		Console.WriteLine("Number of rounds to be taken is " + rounds + "for completing 5km distance");
	}
}
