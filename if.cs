/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: if.cs                             
//DATE: 11 Aug 2016                          
/////////////////////////////////////////////
using System;
class Program
{
	static void Main(string[] args)
	{
		string w1 = "A.CsVsBaNlMcs PtLsZ1X UoItB KeQmWoEcRlTeYWZ G0H3JEKPLCE QoAlSlDeFH" ;
		for ( int  j  = 65 ; j  >= 0 ; j -= 2 )
			Console.Write(w1[j]);
		Console.WriteLine();
		for ( int  j  = w1.Length  - 1 ; j>= 0 ; j--)
			if(j%2!=0)
			{
				Console.Write(w1[j]);
			}
		Console.WriteLine();
		for ( int  j  = 65 ; j  >= 0 ; j--)
		{
			if( j %  2  ==  0 ) {}
			else if( j % 2 != 0  && w1[j] == ' ' )
			{
				Console.WriteLine();
			}
			else if( j  % 2  == 1  && w1 [j] != ' ' )
			{
				Console.Write( w1[j]);
			}
		}
		Console.WriteLine();
		for ( int  j  = w1.Length  - 1 ; j  >= 0 ; j--)
		{
			if ( j%2==0 )
				;
			else if( w1[j] == ' ' )
				{Console.WriteLine();}
			else {Console.Write(w1[j]);}
		}
		Console.WriteLine();
	}
}
