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





		}
	}
}
