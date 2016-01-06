using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на масив row с три елемента
			string[] row = new string[3];
			row [0] = "Ред 1";
			row [1] = "Ред 2";
			row [2] = "Ред 3";

			//Отпечатване на масива
			Console.WriteLine ("Масив row: " + row [0]+","+ row [1]+","+ row [2]+"\n");
			Console.WriteLine ("\n" + "---------" + "\n");


			//Отпечатване на масива с цикъл
			for (int i = 0; i < 3; i++) {
				Console.WriteLine (row [i]+"\n");
			}
			Console.WriteLine ("\n" + "---------" + "\n");


			//Разделяне на стринг (списък) в масив
			string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
			Console.WriteLine ("Броят на елементите в масива:\n" + "1,2,3,4,5,6,7,8,9\ne: " + parse.Length);
			Console.WriteLine ("\n" + "---------" + "\n");

			//Събиране на масив в стринг
			string list1 = string.Join (";", parse);
			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n\n");

			Console.WriteLine ("\n" + "---------" + "\n");




			//Ротативката :) от упражнението след урока ;)
			string[] f = {"портокали","банани","лимони"};
			var r = new Random();
			int a1 = r.Next(0,3);
			int a2 = r.Next(0,3);
			int a3 = r.Next(0,3);
			Console.WriteLine(f[a1]+" "+f[a2]+" "+f[a3]);

			Console.WriteLine ("\n" + "---------" + "\n");

			string [] t = {"малини","ябълки","кайсии"};
			var c = new Random();
			int b1 = c.Next(0,3);
			int b2 = c.Next(0,3);
			int b3 = c.Next(0,3);
			Console.WriteLine (t[b1]+" "+t[b2]+" "+t[b3]);

		}
	}
}
