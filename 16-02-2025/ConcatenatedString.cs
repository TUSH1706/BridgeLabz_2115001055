using System;
using System.Text;
class Concatenate{
	static void Main(){
		Console.WriteLine("Enter the number of strings :");
		int n=int.Parse(Console.ReadLine());
		string[] words=new String[n];
		Console.WriteLine("Enter the strings");
		for(int i=0;i<n;i++)
		{
			words[i]=Console.ReadLine();
		}
		StringBuilder sb = new StringBuilder();
		foreach(string word in words)
		{
			sb.Append(word);
		}
		string result=sb.ToString();
		Console.WriteLine("Concatenated String :" +result);
	}
}
		
	
	
