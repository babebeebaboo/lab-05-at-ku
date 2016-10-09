using System;
class test
{
   static void Main()
   {
      Console.Write("Error code: ");
      char num = (char)Console.Read();
      int num1 = (int)num
      char num2 = (char)Console.Read();
      char num3 = (char)Console.Read();
      char num4 = (char)Console.Read();
      if(num1 == '1')
      {
	 num1 = (num3+num4)%num2;
	 switch(num1)
	 {
	    case 0:
	       Console.WriteLine("Hardware");break;
	    case 1:
	       Console.WriteLine("Driver");break;
	    case 2:
	       Console.WriteLine("Memory");break;
	    case 3:
	       Console.WriteLine("Virus");break;
	    default:Console.WriteLine("Please contact administrator");
	 }
      }
      else if(num1 == '2')
      {
	 Console.WriteLine("Please ask Google");
      }
      else 
      {

	 Console.WriteLine("Please reinstall OS");
      }
   }
}
