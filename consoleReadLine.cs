using System;
class abcd{
	static void Main(){
		while(true){
			Console.Write( "-Press Any Key-......(but if you want to exit press 'x'): ");
			char c = Convert.ToChar(Console.Read());
			if(c=='x')
			{
				Console.WriteLine();
				break;
			}
			if(c!='\n')Console.WriteLine();

			Console.Write("Input1  : ");
			string a = Console.ReadLine();
			Console.Write("Output1 : ");
			Console.WriteLine(a);

			Console.Write("Input2  : ");
			int b = Console.Read();
			if(b!=10)Console.WriteLine();
			Console.Write("Output2 : ");
			Console.WriteLine(b);
		}
	}
}
