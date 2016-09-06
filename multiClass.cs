/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: multiClass.cs                     
//DATE: 11 Aug 2016                          
/////////////////////////////////////////////
using System;
class circle
{
	public static void  area ( int r )
	{
		Console.WriteLine( "Circle Area: {0}" , Math.PI * Math.Pow ( r , 2 ));
	} 
	public static void  circum ( int r )
	{
		Console.WriteLine( "Circumference: {0}" , 2 * Math.PI * r );
	}
} 
class  square
{
	public static void  area ( int l )
	{
		Console.WriteLine( "Square Area: {0}" , Math.Pow ( l , 2 ));
	}
	public static void  peri ( int  l )
	{
		Console.WriteLine ( "Square Perimeter: {0}" , l * 4 );
	}
} 
class  myClass
{
	public static void  Main ()
	{
		int  r  = 2 , l  = 5 ; 
		//call method to make program run correctly
		circle.area(r);
		circle.circum(r);
		square.area(l);
		square.peri(l);
	}
}
