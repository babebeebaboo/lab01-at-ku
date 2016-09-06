/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: palinerr.cs                       
//DATE: 11 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace checkpalin
{
	class palindome
	{
		static void Main()
		{
			Console.WriteLine("Check palindome that is a 4 digits number... ");
			Console.WriteLine("And they are... ");
			for (int i=1000;i<=9999;i++)
			{
				int first = (i%10)/1;
				double second = (i%100)/10;
				float third = (i%1000)/100;
				int fourth = (i%10000)/1000;
				if(first == (fourth) && second == third){
					Console.Write(i);
					Console.Write(" ");
				}
			}
			Console.WriteLine("\nEOF");
		}
	}
}
