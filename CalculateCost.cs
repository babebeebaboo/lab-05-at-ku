/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: CalculateCost.cs                  
//DATE: 8 Sep 2016                           
/////////////////////////////////////////////
using System;

class test
{
   static void Main()
   {
      double cost = 0;
      Console.Write("use nb. LED bulb : ");
      double bulb = Double.Parse(Console.ReadLine());
      double bulbhr =0;
      if(bulb >= 1)
      {
	 Console.Write("how many hours do you use LED bulb : ");
	 bulbhr = Double.Parse(Console.ReadLine());
      }
      cost += 40.0/1000.0*bulb*bulbhr;
      Console.Write("use nb. TV : ");
      double TV = Double.Parse(Console.ReadLine());
      double TVhr =0;
      if(TV >= 1)
      {
	 Console.Write("how many hours do you use TV : ");
	 TVhr = Double.Parse(Console.ReadLine());
      }
      cost += 75.0/1000.0*TV*TVhr;
      Console.Write("use nb. air conditioner : ");
      double air = Double.Parse(Console.ReadLine());
      double airhr =0;
      if(air >= 1)
      {
	 Console.Write("how many hours do you use air conditioner : ");
	 airhr = Double.Parse(Console.ReadLine());
      }
      cost += 1000.0/1000.0*air*airhr;
      Console.Write("use nb. fan : ");
      double fan = Double.Parse(Console.ReadLine());
      double fanhr =0;
      if(fan >= 1)
      {
	 Console.Write("how many hours do you use fan : ");
	 fanhr = Double.Parse(Console.ReadLine());
      }
      cost += 45.0/1000.0*fan*fanhr;
      Console.Write("use nb. refrigerator : ");
      double re = Double.Parse(Console.ReadLine());
      double rehr =0;
      if(re >= 1)
      {
	 Console.Write("how many hours do you use refrigerator : ");
	 rehr = Double.Parse(Console.ReadLine());
      }
      cost += 95.0/1000.0*re*rehr;
      Console.Write("use nb. washing machine : ");
      double wm = Double.Parse(Console.ReadLine());
      double wmhr =0;
      if(wm >= 1)
      {
	 Console.Write("how many hours do you use washing machine : ");
	 wmhr = Double.Parse(Console.ReadLine());
      }
      cost += 900.0/1000.0*wm*wmhr;
      Console.WriteLine("Cost of electricity to day is {0:F2} Bath.",cost*3);
   }
}
