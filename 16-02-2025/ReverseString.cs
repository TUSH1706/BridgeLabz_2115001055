using System;
using System.Text;
class ReverseString{
	static void Main(){
		Console.WriteLine("Enter string :");
		string input=Console.ReadLine();
		StringBuilder sb= new StringBuilder(input);
		int left=0;
		int right=sb.Length-1;
		while(left<right)
		{
			char temp=sb[left];
			sb[left]=sb[right];
			sb[right]=temp;
			left++;
			right--;
		}
		Console.WriteLine("reversed string : " + sb.ToString());
	}
}

			