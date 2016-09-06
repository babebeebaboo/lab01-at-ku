using System;
class Comment
{
	static void Main(string[] args)
	{
		string a = "CPE";
		int b=30;
		double c = 5.52;
		Console.WriteLine("{0} {1} {2}",a,b,c);
		Console.WriteLine("{1} {0} {2}",a,b,c);
		Console.WriteLine("{2} {1} {0}",a,b,c);
		Console.WriteLine("{2} {2} {2}","Hi","Com","Mike");
	}
}
