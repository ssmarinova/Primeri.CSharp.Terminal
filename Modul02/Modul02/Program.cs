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

			//Събиране на числа
			a = 10; 
			b = 5; 
			sum = a + b;

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


			Console.WriteLine ("\n Използване на ++");
			a ++; //, a=a+1
			Console.WriteLine (a);

			Console.WriteLine ("Стандартно делене: " + ( 14 / 4 ).ToString()); // ->2
			Console.WriteLine ("Остатък от делене: " + ( 14 % 4 ).ToString()); // ->1





			Console.WriteLine ("\n Използване на --");
			a --; // a=a-1
			Console.WriteLine (a);


		}
	}
}
