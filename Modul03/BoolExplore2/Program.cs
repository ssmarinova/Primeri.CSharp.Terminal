using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		
			int[] _i = new int[] { 4, 3, 2 };

			int _ui = 0;  

			string _input = "0";
			Console.Write ("Моля въведете индекс: ");
			_input = Console.ReadLine ();

			//Проверка дали въведеното от потребителя е число
			bool _check01 = int.TryParse (_input, out _ui); 




			//Предпазване на програмата от счупване
			// в случая от некоректно въведени данни от оператора
			try
			{
				Console.Write ("Елемент " + _ui.ToString()+" от масива е: ");
				Console.WriteLine (_i [_ui-1]);

			}catch{
				Console.WriteLine ("Недефиниран елемент");
			}











			//Използване на условно присвояване
			//ако потребителя въведе по-голямо число, присвоява последното, ако въвде по-малко - присвоява първото - без да дава индикации 
//			_ui	= (_ui <= _i.Length) ? _ui : 3; //Ако _ui <= _i.Length, да се запази _ui, иначе да стане 3 
//			_ui	= (_ui > 0) ? _ui : 1;




			//Използване на switch
//			switch (_ui) {
//			case 1:
//				{ 
//					Console.Write ("Първи елемент от масива: ");
//					Console.WriteLine (_i [_ui-1]);
//					break;
//				}
//			case 2:
//				{ 
//					Console.Write ("Втори елемент от масива: ");
//					Console.WriteLine (_i [_ui-1]);
//					break;
//				}
//			case 3:
//				{ 
//					Console.Write ("Трети елемент от масива: ");
//					Console.WriteLine (_i [_ui-1]);
//					break;
//				}
//			default: 
//				{
//					Console.Write ("В масива няма стойност за този индекс. \nОпитайте с индекс между 1 и 3 \n\n");
//					break;
//				}
//			}







//			if (_check01) {
//				Console.WriteLine (_i [_ui - 1]);
//			} 

			//  !!не дава грешка ако се въведе буква или друг символ 






		} //метод
	}
}
