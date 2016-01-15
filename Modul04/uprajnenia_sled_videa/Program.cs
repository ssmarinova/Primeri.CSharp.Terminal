﻿using System;

namespace uprajnenia_sled_videa
{
	class MainClass
	{
		public static void Main (string[] args)
		{













//----------------------------------------------------------------------------------------

		/*  ВИДЕО 2
		В случая имаме раздробена на думи скоропоговорка, която е вече в масива a. 
		Сега ще минем през всеки елемент от него (всяка дума) и ще ги размешаме. 
		Всяка четна дума ще мине пред предходната нечетна. За това ще създадем цикъл 
		който да мине от 1 до 8 (16 са думите)
		*/
			string c = "Петър плет плете по три пръта преплита плети ";
			c += "Петре плета подпри Петре плета падна Петре плета";
			string[] a = c.Split(' ');

			//Предложено решение
			for(int i=0; i < a.Length/2; i++) {
				Console.Write( a[i*2 + 1]+" "+a[i*2]+ " " );
			}


			//Моето решение - вариант 1 - отпечатване на масива разбъркан
			for (int i=0; i<a.Length; i+=2) {
				Console.Write (a[i+1] + " " +a[i]+" ");
			}

			//Моето решение - вариант 2 - промяна на масива
				//1. Разменяне на думите в масива
			for (int i = 0; i<a.Length; i+=2) {
				string b = a[i];
				a[i] = a[i+1];
				a[i+1]=b;
				b="";
			}
				//2. Отпечатване на новия масив
			for (int j = 0; j<a.Length; j++) {
				Console.Write (a[j]+" ");
			}

//--------------------------------------------------------------------------------------------------

			/* ВИДЕО 2
			В този пример правим почти същото, но използваме друг алгоритъм за 'shuffle' 
			(произволно разместване) на елементите в масива. След което ги изпечатваме на екрана.
			Анализирайте алгоритъма и прочетете коментарите към кода
			*/


			string p = "Петър плет плете по три пръта преплита плети ";
			p += "Петре плета подпри Петре плета падна Петре плета";
			string[] k = c.Split(' ');

			string tmp = ""; 	// Създаваме си временна променлива която
								// ще ни помогне да подменим един елемент с друг
								// 'tmp' идва от 'temporary', което значи 'временен'

			var r = new Random(); // Нашият генератор на произволни числа

			var rand = 0;         // Тук ще слагаме произволните числа

			for(int i=0; i < k.Length ; i++) { 	// Цикъл от 0 до 
												// (колкото е дълъг масива 'a')

				rand = r.Next(0,i+1); 	// Взимаме произволно число
				tmp = k[i];           	// Запаметяваме какво има в клетката a[i]
				k[i] = k[rand];       	// Взимаме дума от клетка a[rand] и я
										// слагаме в клетка a[i]
										// В този момент ако не пазехме стойността на
										// a[i] в 'tmp', щяхме да я загубим

				k[rand] = tmp;        	// Но понеже я пазим - ще я сложим в 
										// клетката a[rand]
			}

			// След което ще съберем нашият масив в текстов низ, като разделяме
			// думите с разстояния и ще ги покажем на екрана
			Console.WriteLine( string.Join(" ", k) ); 






		} //krai masiv
	}
}
