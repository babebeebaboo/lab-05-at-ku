/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: logic.cs                          
//DATE: 8 Sep 2016                           
/////////////////////////////////////////////
using System;

class test
{
	static void Main()
	{
		print(sol(input(1),input(2),input(3)));
	}
	static bool sol(string a,string b,string c)
	{
		bool A = (a=="True")? true:false;
		bool B = (b=="True")? true:false;
		if(c=="^")return A&&B;
		if(c=="v")return A||B;

		if(c=="->")return !A||B;
		if(c=="<->")return !(A^B);
		return true;
	}
	static string input(int a)
	{
		string aa="";
		if(a==1)
		{
			Console.Write("Input A : ");
			aa = Console.ReadLine();
		}
		if(a==2)
		{
			Console.Write("Input B : ");
			aa = Console.ReadLine();
		}
		if(a==3)
		{
			Console.Write("Input Symbol : ");
			aa = Console.ReadLine();
		}
		return aa;
	}
	static void print(bool a)
	{
		if(a==true)Console.WriteLine("Resolution : True");
		if(a==false)Console.WriteLine("Resolution : False");
	}
}

