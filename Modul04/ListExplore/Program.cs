using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			// Дефиниции
			string usimp = "";
			// Дефиниране на лист = като масив, но е по-динамичен - може да добавяме и трием елементи без проблем.
			List<int> mylist1 = new List<int> ();


			mylist1.Add (5);
			mylist1.Add (3);
			mylist1.Add (9);


			//Потрбителски вход
			do {
				Console.Write ("? ");
				usimp = Console.ReadLine ();

				// Добавяне на стойности


				//Преглед на листа
				if( usimp.Contains("show") ) {
					Console.Write ( "Съдържанието на листа е: ");
					for (int i=0; i<mylist1.Count; i++) {
						Console.Write (mylist1 [i]);

						if ( i != mylist1.Count -1) Console.Write (", ");
					}
					Console.WriteLine ();
				}

				//размер на листа




			} while(usimp != "exit");





		}//krai metod
	}
}
