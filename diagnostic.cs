/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: diagnostic.cs                     
//DATE: 8 Sep 2016                           
/////////////////////////////////////////////
using System;

class test
{
   static void inp(ref string num)
   {
      Console.Write("Error code: ");
      num = Console.ReadLine();
   }
   static void findProblem(int num)
   {
      int l2= (num%1000 - num%100)/100;
      int l3=(num%100 - num%10)/10;
      int l4=num%10;
      if((l3+l4)%l2 ==0)Console.WriteLine("Hardware");
      else if((l3+l4)%l2==1)Console.WriteLine("Driver");
      else if((l3+l4)%l2==2)Console.WriteLine("Memory");
      else if((l3+l4)%l2==3)Console.WriteLine("Virus");
      else Console.WriteLine("Please contact administrator");
   }
   static void analyse(ref string number)
   {
      int aa;
      if(Int32.TryParse(number,out aa) == false)
	 Console.WriteLine("Error: wrong input");
      else 
      {
	 int num = int.Parse(number);
	 if(num>=1000 && num<=9999)
	 {
	    if(num/1000 ==1)findProblem(num);
	    else if(num/1000==2)Console.WriteLine("Please ask Google");
	    else Console.WriteLine("Please reinstall OS");
	       
	 }
	 else  
	    Console.WriteLine("Error: wrong input");
      }
   }
   static void Main()
   {
      string number="";
      inp(ref number);
      analyse(ref number);
   }
}
