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

			// проба от въпросите под видеото
//			string input = Console.ReadLine ();

//			if ( int.TryParse ( input, out b) )


			//Печат на резултат
			Console.WriteLine ( "резултата a+b е: " +(a+b).ToString()+ "\n\n\n");
		
			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 25";
			test += ", 5";

			//Събира горните данни на един ред с разделител запетайка и интервал
			Console.WriteLine ("Събиране с += " + test + "\n");
			//Показва кой е четвъртия знак, т.е. след (разделител) номер 3
			Console.WriteLine ("4-ти знак: " + test.Split (',')[3] + "\n\n\n");


			//променя разделителя
			test = test.Replace (", ", ";");
			Console.WriteLine ("Работа с Replace: " + test + "\n");
			//Показва кой е третия знак, т.е. след (разделител) номер 2
			Console.WriteLine ("3-ти знак: " + test.Split (';')[2]+ "\n\n\n");
			
		
		}
	}
}