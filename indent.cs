/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: indent.cs                         
//DATE: 11 Aug 2016                          
/////////////////////////////////////////////
using System;
class indent
{
	static void Main()
	{
		string a = Console.ReadLine();
		string b = Console.ReadLine();
		string c = Console.ReadLine();
		if(a == "A")
		{
			if(b == "AB")
				if(c == "ABC")
				{
					string d = Console.ReadLine();
					if(d == "ABCD") 
						Console.WriteLine("You're right!");
					else 
						Console.WriteLine("You're wrong!");
				}
			else if(c == "CBA")
			{
				string e = Console.ReadLine();
				if(e == "DCBA")
				{
					Console.Write("Fight for mom!");
					if(a == "A")
						if(b == "AB")
							if(c == "ABC")
								Console.WriteLine("Easy!");
				}
				else 
					Console.Write("Fight for dad!");
			}
			else 
				Console.WriteLine("if A, AB or ABC");
			if(b == "BA") 
				Console.Write("You're on the right track!");
		}
		else if(a == "A1") 
			Console.WriteLine("MoChit -> DonMuang");
		else 
			Console.WriteLine("Hello");
	}
}
