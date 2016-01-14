using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{

//			bool _b = true;
//
//			bool _test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2 };

			int _ui = 0;  //Convert.ToInt32 (Console.ReadLine () );

			string _input = "0";
			Console.Write ("Моля въведете индекс: ");
			_input = Console.ReadLine ();

			//Проверка дали въведеното от потребителя е число
			bool _check01 = int.TryParse (_input, out _ui); //int.TryParse конвертира текст в тип int, като връща резултат дали се е справил или - не. 
			                                                //Kомандата означава: превърни _input (което е string) в променливата _ui (която е int).


			//Проверка на горната граница
			bool _check02 = _ui <= _i.Length;


			//Проверка на долната граница
			bool _check03 = _ui > 0;




			if (_check01 && _check02 && _check03) {
				Console.WriteLine (_i [_ui - 1]);
			} 

			if (!_check01) {
				Console.WriteLine ("Индекс трябва да бъде цяло число.\n\n\n");
			}
			if (!_check02) {
				Console.WriteLine ("Индекса е прекалено голям.\n\n\n");
			}
			if (!_check03 && _check01) {
				Console.WriteLine ("Моля въведете число по-голямо от 0.\n\n\n");	
			}
			  



			//			bool _check01 = _ui <= _i.Length;
			//			bool _check02 = _ui > 0;
			//
			//			bool _exp01 = _check01 &&	_check02;     //Лофическо и "&&".
			//			bool _exp02 = _check01 ||	_check02;     //Лофическо или "||".
			//			bool _exp03 = !_check01;     //Лофическо отрицание "!".
			//
			//
			//
			////			Console.WriteLine (_test);
			////			Console.WriteLine (_b);
			////			Console.WriteLine ();
			//
			////			Console.WriteLine (_check01);
			////			Console.WriteLine (_check02);
			////			Console.WriteLine ( _i [_ui-1] );
			//
			//			Console.WriteLine ("Логическо и: " + _exp01.ToString () );
			//			Console.WriteLine ("Логическо или: " + _exp02.ToString () );
			//			Console.WriteLine ("Отрицание на: " + _check01.ToString () + ": " + _exp03);


		}  //kraj Metod
	}
}
