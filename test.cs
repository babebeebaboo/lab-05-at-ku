/////////////////////////////////////////////
//NAME: Supakorn Wongsawang
//ID: 5910500147
//PROGRAM: RegisId.cs
//DATE: 9 Sep 2016
/////////////////////////////////////////////
using System;
class test
{
	static int Main()
	{
		string input="";
		if(inp(ref input)==false)
		{
			Console.WriteLine("Error");
			return 0;
		}
		string tmp ="";tmp = tmp+input[0];tmp = tmp+input[1];
		int year = int.Parse(tmp);
		Console.WriteLine("Admission Year : 25{0}/20{1}",year,year-59+16);
		string nu="";nu=nu+input[2];nu=nu+input[3];nu=nu+input[4];
		Console.WriteLine("Number order in University : {0}",nu);
		Console.WriteLine("Faculty : {0}",faculty(input));
		Console.WriteLine("Department : {0}",depart(input));
		int chk = (12-1) * (input[0]-48)+(12-2) * (input[1]-48)+(12-3) * (input[2]-48)+(12-4) * (input[3]-48)+(12-5) * (input[4]-48)+(12-6) * (input[5]-48)+(12-7) * (input[6]-48)+(12-8) * (input[7]-48)+(12-9) * (input[8]-48)+(12-10) * (input[9]-48)+(12-11) * (input[10]-48);
		Console.WriteLine("Check digit : {0}",chk%11);
		return 1;
	}
	static string depart(string i)
	{
		string a="";
		string b="";b=b+i[5];b=b+i[6];b=b+i[7];b=b+i[8];b=b+i[9];b=b+i[10];
		switch(int.Parse(b))
		{
			case 210101:a="Internal organs system,Human";break;
			case 210102:a="External organs system,Human";break;
			case 210201:a="Flyable animals,Small animals";break;
			case 210202:a="Unflyable animals,Small animals";break;
			case 210300:a="-,Big animals";break;
			case 220101:a="Hardware,Computer";break;
			case 220102:a="Software,Computer";break;
			case 220200:a="-,Electrical";break;
			case 220301:a="Car engine,Mechanic";break;
			case 220302:a="Marine engine,Mechanic";break;
			case 220303:a="Aircraft engine,Mechanic";break;
			case 230101:a="Physics,Physical";break;
			case 230102:a="Chemistry,Physical";break;
			case 230103:a="Applied,Physical";break;
			case 230201:a="Biology,Biological";break;
			case 230202:a="Microbiology,Biological";break;
		}
		return a;
	}
	static string faculty(string i)
	{
		string c = "";c=c+i[5];c=c+i[6];
		if(c=="21")return "Medicine";
		if(c=="22")return "Engineering";
		if(c=="23")return "Science";
		return "Error";
	}
	static bool inp(ref string input)
	{
		Console.Write("Input ID : ");
		input = Console.ReadLine();
		long a;
		return Int64.TryParse(input,out a);
	}
}
