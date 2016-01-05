using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b=0;
			int sum = 0;
			string program_name = "Модул 02 - Примери";
			string program_version = "1.0";

			//Събиране на числа
			a = 10; 
			b = 5; 
			sum = a + b;

			//данни за програмата

			Console.WriteLine (program_name);
			Console.WriteLine ("Версия: " + program_version + "\n\n");


			//Писане в конзолата
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine ("\n Използване на +=");
			a += b; //a=10+5, a=a+b
			Console.WriteLine (a);

			Console.WriteLine ("\n Използване на -=");
			a -= b; // a=a-b
			Console.WriteLine (a);

			Console.WriteLine ("\n Използване на *=");
			a *= b; // a=a*b
			Console.WriteLine (a);

			Console.WriteLine ("\n Използване на /="); //Делението е по-специфично примери по-долу
			a /= b; // a=a*b
			Console.WriteLine (a);

			Console.WriteLine ("\n Използване на ++");
			a ++; //, a=a+1
			Console.WriteLine (a);

			Console.WriteLine ("\n Използване на --");
			a --; // a=a-1
			Console.WriteLine (a);

			Console.WriteLine ("Стандартно делене: " + ( 14 / 4 ).ToString()); // дава цялото число от делението
			Console.WriteLine ("Остатък от делене: " + ( 14 % 4 ).ToString()); // дава неразделената част от делимото
		
			Console.WriteLine (program_name);
		
			
		
		
		
		
		}
	}
}
