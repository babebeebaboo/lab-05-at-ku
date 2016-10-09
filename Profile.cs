/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: Profile.cs                        
//DATE: 8 Sep 2016                           
/////////////////////////////////////////////
using System;

class test
{
   static void Main()
   {
      Console.Write("Name : ");
      string name = Console.ReadLine();

      Console.Write("Age : ");
      int age = int.Parse(Console.ReadLine());
      Console.Write("Gender : ");
      string gen = Console.ReadLine();
      Console.Write("Height : ");
      double hi = double.Parse(Console.ReadLine());
      Console.Write("Weight : ");
      double we = double.Parse(Console.ReadLine());
      Console.Write("{0}, age:{1} gender:{2} height:{3:f2} weight:{4:f2}BMI:{5:f2}",name,age,gen=="M"?"male":"female",hi,we,we/hi/hi);
   }
}
