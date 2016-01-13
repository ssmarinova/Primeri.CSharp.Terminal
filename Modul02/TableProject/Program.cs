﻿using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime = 0, familia, godini};

		public static void Main (string[] args)
		{

			//Дефиниране на двумерен масив
			string[,] table = new string[2,3];

			//Въвеждане на първи ред
			table[0,(int) ti.ime ] = "Мартин";		table[0,(int) ti.familia] = "Симеонов"; 	table[0,(int) ti.godini] = "31";


			//Въвждане на втори ред
			table[1,(int) ti.ime ] = "Симеон";  	table[1,(int) ti.familia] = "Мартинов"; 	table[1,(int) ti.godini] = "41";

			//Отпечатване
			Console.Write ("Кой ред искате да видите: ");
			int _ind = Convert.ToInt32 (Console.ReadLine ())-1;

			Console.WriteLine (
				(table [_ind, (int) ti.ime]) [0] + ". " + 
				 table [_ind, (int) ti.familia]  + " "  + 
				 table [_ind, (int) ti.godini]   + " г."
			);






//			//Дефиниране на масив row с три елемента
//			string[] row = new string[3];
//			row [0] = "Ред 1";
//			row [1] = "Ред 2";
//			row [2] = "Ред 3";
//
//			//Отпечатване на масива
//			Console.WriteLine ("Масив row: " + row [0]+","+ row [1]+","+ row [2]+"\n");
////			Console.WriteLine ("\n" + "---------" + "\n");
//
//
//			//Отпечатване на масива с цикъл
//			for (int i = 0; i < 3; i++) {
//				Console.WriteLine (row [i]+"\n");
//			}
//			Console.WriteLine ("\n" + "---------" + "\n");
//
//
//			//Разделяне на стринг (списък) в масив
//			string[] parse = "1,(int) ti.godini,3,4,5,6,7,8,9".Split(',');
//			Console.WriteLine ("Броят на елементите в масива:\n" + "1,(int) ti.godini,3,4,5,6,7,8,9\ne: " + parse.Length);
//			Console.WriteLine ("\n" + "---------" + "\n");
//
//			//Събиране на масив в стринг
//			string list1 = string.Join (";", parse);
//			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n\n");
//
//			Console.WriteLine ("\n" + "---------" + "\n");



//			Видео 06 Задачи:
//
//			  1.Да се напише програма, която създава масив с 20 елемента от целочислен тип и инициализира 
//			всеки от елементите със стойност равна на индекса на елемента, умножен по 5. 
//			Елементите на масива да се изведат на конзолата. (Hint: Използвайте масив int[] и for цикъл.)
//			  2.Да се напише програма, която чете два масива от конзолата и проверява дали са еднакви. 
//			(Hint: Два масива са еднакви, когато имат еднаква дължина и стойностите на елементите в тях 
//			съответно съвпадат.)
//			  3.Да се провери дали един масив е симетричен. (Hint: За да проверим дали масивът е 
//			симетричен, трябва да го обходим само до средата. Тя е елементът с индекс array.length / 2. 
//			При нечетна дължина на масива този индекс е средният елемент, а при четна – елементът 
//			вляво от средата, понеже средата е между два елемента.)
//			  4.Да се дефинира масив, като стойностите да се прочитат от командния ред. 
//			След това тези стойности в масива да се изведат в обратен ред


//////			Задача 1
//////
//			int [] Z1 = new int[20];
//			for (int j =0; j<20; j++) {
//				Z1 [j] = j*5;
//			}
//			for (int j = 0; j < 20; j++) {
//				Console.WriteLine ("За елемент " + j+ " от масива цифрата е: " + Z1 [j]+";");
//			}
//
//			Console.WriteLine ("\n");
//
//			for (int j = 0; j < 19; j++) {
//				Console.Write (Z1[j]+";");
//			}
//			Console.Write (Z1 [19]);
//
//			Console.WriteLine ("\n" + "---------" + "\n");
//
//			// Решение на колега от форума
//			int[] input = new int[21] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
//			for (int i = 0; i < input[20]; i++)
//			{
//				int multi;
//				multi = 5 * input[i];
//				Console.Write("{0},",multi);
//			}
//			Console.ReadLine();

			//
//
//
////			Задача 2 - недовършена
//			Console.WriteLine ("Задача 2");
//			int [] Z2a = new int[10];
//			for (int j1 =0; j1<10; j1++) {
//				Z2a [j1] = j1*5;
//			}
//str
//			int [] Z2b = new int[15];
//			for (int j2 =0; j2<15; j2++) {
//				Z2b [j2] = j2*5;
//			}
//
//			int d1 = Z2a.Length;
//			int d2 = Z2b.Length;
//
//			object d3 = (d1 = d2);
//							
//			if (d3) {
//				for (int x =0; x<20;x++) {
//					object st = (Z2a [x] = Z2a [x]);
//
//					if (st) {
//						Console.WriteLine("Масивите са еднакви");
//						Console.WriteLine("Масивите не са еднакви");
//					};
//				};
//			Console.WriteLine("Масивите не са еднакви");
//			}











		}
	}
}

//			//Ротативката :) от упражнението след урока ;)
//			string[] f = {"портокали","банани","лимони"};
//			var r = new Random();
//			int a1 = r.Next(0,3);
//			int a2 = r.Next(0,3);
//			int a3 = r.Next(0,3);
//			Console.WriteLine(f[a1]+" "+f[a2]+" "+f[a3]);
//
//			Console.WriteLine ("\n" + "---------" + "\n");
//
//			string [] t = {"малини","ябълки","кайсии"};
//			var c = new Random();
//			int b1 = c.Next(0,3);
//			int b2 = c.Next(0,3);
//			int b3 = c.Next(0,3);
//			Console.WriteLine (t[b1]+" "+t[b2]+" "+t[b3]);




