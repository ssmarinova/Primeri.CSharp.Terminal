using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/*
			Методите са парчета от код,които имат няколко опции:
			 - само да се изпълнят
			 - да върнат параметри
			 - референции */
			 




			//Дефиниции

			string usercommand = "";


			//Потребителски команди
			do {
				Console.Write ("$ "); 
				usercommand=Console.ReadLine();

				if (usercommand.Contains("cmd01")) cmd01 (usercommand);
				if (usercommand.Contains("cmd02")) Console.WriteLine(cmd02 (usercommand));


			} while (usercommand != "exit");





		}
		//- само да се изпълнят:
		public static void cmd01 (string imp)
		{
		//test е името на метода
		//void отговаря за това какво ще върне метода. когато сложим void - не въща нищо.
			//ако искаме да върне стринг - public static string
		
			try{

				//задачата е поребителя да напише test 5, което ще върне резултат 5^2
				double temp = 0;
				if (double.TryParse (imp.Split(' ')[1],out temp)) {  
					//TryParse конвертита зададеното след него в типа зададен преди него. Връща bool отговор, затова се слага в условен оператор.
					//с imp.Split(' ')[1] обединяваме въведения от потребителя текст (test 5) в общ стринг от 2 части: test  и 5. 
					//Вземаме вторият елемент "5" и с out temp отива в променливата temp.


					//Принципно out отговаря за даване на референции към дадена променлива.

					Console.WriteLine ("\nРезултатът от " + temp.ToString () + "^2 e:" + (temp * temp).ToString());
				}





			}catch{
			}
		
		
		
		}

		public static int cmd02 (string imp)
		{

			int temp = 0;
			if (int.TryParse (imp.Split(' ')[1],out temp)) {  
				temp = temp * temp* temp;
			}	

			return temp;


		}

	}
}
