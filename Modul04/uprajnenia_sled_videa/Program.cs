﻿using System;

namespace uprajnenia_sled_videa
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/* ВИДЕО 05
		Две напред, една назад. Вашата задача тук е да напишете програма която да показва числата 2, 1, 3, 2, 4, 3, 5, 4 ... до 10.
		Тоест веднъж добавяме 2, а следващата итерация изваждаме едно и повтаряме. 
		Опитайте се да напишете програмта сами, като използвате while. */
			
			//Мое решение
			int j=0;
			do {
				Console.Write ( j+2 + ", ");
				Console.Write ( j+1 + ", ");
				j++;
			} while (j<=8);

			Console.WriteLine ("\n\n");
			 //Предложено решение
			int i=0;
			bool napred=true;
			while(i < 10) {
				if (napred) {
					napred=false;
					i+=2;
				} else {
					napred=true;
					i--;
				}
				Console.Write(i+ ", ");
			}



			/*Сигурно се уморихте да пишете "Console.WriteLine" по 100 пъти. 
			 * Сега ще разберем как може да си направим 'shortcut' към тази команда */

			Action<string> cw = Console.WriteLine;










			/* ВИДЕО 3
		Време ви е да се сблъскате с първият си изкуствен интелект. Не ви ли писна да пишете код? 
		Не бихте ли искали компютърът сам да си пише кода вместо вас? Това и прави тази програма.
		Имаме три числа в масив и искаме да получим числото 15 от тях. 
		Но не ни се пише формула от сорта на x + y * x + z + z*x, ще оставим компютърът да го направи.
		За целта създаваме един цикъл, който да се опитва да направи точно това 100 пъти. 
		Ако не успее за 100 пъти, здраве да е, няма да го мъчим.
		Всеки от тези 100 пъти, той ще комбинира разни математически операции до 20 пъти на формула, 
		след което ще се откаже и ще пробва отначало.
		Всеки път ще избира две произволни числа от масива и ще извършва произволна операция между тях, 
		след което ще ги събира всичките такива в променливата res.
		А пък в rs ще помни текстово какви ги е правил и ще ни показва, 
		ако е намерил формула с числата ни, която да дава резултат 15.
		Така, сблъскахте се с първия си генетичен алгоритъм. 
		Единствено му липсва системата за оценка на различните проби и миксирането на качествени проби. 
		Но ако си пофантазирате малко, може да намерите доста приложения на нещо такова.	 */

			int[] a = {1,2,3};
			int i=0, j=0;
			int r_op=0; 		// Тук записваме произволната команда
			int r_num1=0;		// Номер на първо произволно число от масива
			int r_num2=0; 		// Номер на второ произволно число от масива
			var r = new Random();

			string rs = ""; 	// Тук ще пазим текстовата формула до момента
			int res = 0; 		// Тук ще смятаме произволно
			int found = 0; 		// Тук пазим колко формули сме намерили до момента

			for(i=0; i<100;i++) {
				rs = ""; 		// Всяка нова итерация ще изтриваме rs и res 
				res = 0; 
				for(j=0; j<20; j++) {
					r_op = r.Next(0,3); 	// Тук се решава дали ще събираме, изваждаме или делим
					r_num1 = r.Next(0,3);
					r_num2 = r.Next(0,3);

					switch(r_op) {
					case 0: 
						{
							res += a[r_num1] + a[r_num2];
							rs += a[r_num1]+" + "+a[r_num2]+ " + ";
							break;      
						}
					case 1: 
						{
							res += a[r_num1] * a[r_num2];
							rs += a[r_num1]+" * "+a[r_num2]+ " + ";
							break;      
						}
					case 2: 
						{
							res += a[r_num1] - a[r_num2];
							rs += a[r_num1]+" - "+a[r_num2]+ " + ";
							break;      
						}
					}

					if (res == 15) { 		// Воала. Намерихме правилна формула
						Console.WriteLine(rs+ " 0 = 15\n");
						found++;
						break;
					}

				}
				if (found > 5) break; 		// Не искаме повече от 6 формули

			}













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
