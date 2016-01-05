using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на променливи
			int a = 6, b = 0;


			//Въвеждане на параметри - пояснява на колко е равно a и изисква въвеждане на b
			Console.Write ("a=" + (a)+", Моля въведете b: ");
			b= Convert.ToInt32 (Console.ReadLine ());





			//Печат на резултат
			Console.WriteLine ( "резултата a+b е: " +(a+b).ToString()+ "\n\n\n");
		}
	}
}
