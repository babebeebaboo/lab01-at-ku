/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: ring.cs                           
//DATE: 11 Aug 2016                          
/////////////////////////////////////////////
using System;
class ring
{
	static void Main()
	{
		double inner_2radius=3.2;
		double outer_2radius=4.5;
		Console.WriteLine(Math.PI *( Math.Pow(outer_2radius/2,2) - Math.Pow(inner_2radius/2,2) ) );
	}
}
