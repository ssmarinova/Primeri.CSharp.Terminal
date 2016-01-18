using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] tbl = {
				{ "Иван",    "Георгиев", 	"19" },
				{ "Васил", 	"Иванов", 		"23" },
				{ "Милен", 	"Георгиев", 	"58" },
				{ "Цветан", 	"Бориславов", 	"14" },
				{ "Гергана", "Василева", 	"25" },
				{ "Ивана",	 "Христова", 	"21" }
			};

			//Антетка на таблица
				Console.WriteLine ("Име".PadRight(12) + "Фамилия".PadRight(12)+ "Години".PadRight(12));
			Console.WriteLine ("===========================================");


			//Тяло на таблица
				//Пример с for
//			for (int i = 0; i < tbl.Length / 3; i++) {
//				for (int j = 0; j < 3; j++) {
//					
////				Код на цикъла
//					Console.Write (tbl [i, j].PadRight (12));
//				}
//				Console.WriteLine ();
//			}


			   //Пример в while
//			int i = 0;
//			while (i < tbl.Length / 3) {
//				Console.WriteLine (tbl[i,0].PadRight(12) + tbl[i,1].PadRight(12)+ tbl[i,2].PadRight(12));
//				i++;			
//			}



				// Пример с do ... wile

			int i = 0;
			do {
				Console.WriteLine (tbl[i,0].PadRight(12) + tbl[i,1].PadRight(12)+ tbl[i,2].PadRight(12));
				i++;
				}while(i < tbl.Length / 3);




			//Console.WriteLine ("Hello World!");
		} //modul
	}
}
