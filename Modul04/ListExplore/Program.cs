using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на shrtcut към команда
			Action<string> cwl = Console.WriteLine;


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
				 
				// Добавяне на стойности = move da se dobawq samo add <int>
				if(usimp.ToLower().Contains ("add")) {
					try {
						int pAdd = 0;
						if( int.TryParse(usimp.Split(' ')[1], out pAdd)) {
							mylist1.Add (pAdd);
						}
						Console.WriteLine();

					}catch {}
				}

				//Преглед на листа
				if( usimp.ToLower().Contains("show") ) {
					Console.Write ( "Съдържанието на листа е: ");

					//Отпечатване на списъка с foreach
					foreach (int val in mylist1){
						Console.Write (val.ToString()+", ");
					}



					//Отпечатване на списъка с for
//					for (int i=0; i<mylist1.Count; i++) {
//						Console.Write (mylist1 [i]);
//
//						if ( i != mylist1.Count -1) Console.Write (", ");
//					}
					Console.WriteLine ("\n");
				}

				//размер на листа
				if (usimp.ToLower().Contains("size")) {
					Console.WriteLine ("размера на списъка: " + mylist1.Count.ToString() + "\n");
				}


			} while(usimp != "exit");





		}//krai metod
	}
}
