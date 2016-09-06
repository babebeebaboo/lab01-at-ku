/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: error.cs                          
//DATE: 11 Aug 2016                          
/////////////////////////////////////////////
using System;//using System instead using system
class error
{
	public static void Main(string[] args)
	{
		string new1 = "Books";//new is reserved keyword
		string a = "Hello";
		Console.WriteLine("{0}{1}","Hello","World"); //Forgot Semicolon(;)
		Console.WriteLine("{0} {1}",a,new1); // Two Double quote at the first of string AND new is reserved keyword
	}
}
