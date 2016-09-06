/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: bracket.cs                        
//DATE: 11 Aug 2016                          
/////////////////////////////////////////////
using System;
class myProgram{
  public static void Main(string[] args){
    string [,] myArray  = {{ "Mind" , "God" , "Eat" },{ "Books" , "Pantip" , "Camera" },{ "Poby" , "Teacher" , "" },{ "Plam" , "Series" , "" }};
    for ( int  i  = 0 ; i  < myArray.GetLength ( 0 ); i++){
      Console.WriteLine( " [{0}] student" , i + 1 );
    	int  j  = 0 ;
    	while ( j  < myArray.GetLength ( 1 )){
      	if(j< 1 ){//Add{
        		Console.Write( "Name : {0} " , myArray [ i , j ]); 
        		Console.WriteLine();
			}//Add}
      	else if( myArray [ i , j ] != "" ){//Add{
        		Console.WriteLine( "Status : {0} " , myArray [ i , j ]);
      	}
      	j++;
		}
	}
  }
}
