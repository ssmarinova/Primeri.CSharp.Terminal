using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			bool _b = true;

			bool _test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2 };

			int _ui = Convert.ToInt32 (Console.ReadLine () );

			bool _check01 = _ui <= _i.Length;
			bool _check02 = _ui > 0;

			bool _exp01 = _check01 &&	_check02;     //Лофическо и "&&".
			bool _exp02 = _check01 ||	_check02;     //Лофическо или "||".
			bool _exp03 = !_check01;     //Лофическо отрицание "!".



//			Console.WriteLine (_test);
//			Console.WriteLine (_b);
//			Console.WriteLine ();

//			Console.WriteLine (_check01);
//			Console.WriteLine (_check02);
//			Console.WriteLine ( _i [_ui-1] );

			Console.WriteLine ("Логическо и: " + _exp01.ToString () );
			Console.WriteLine ("Логическо или: " + _exp02.ToString () );
			Console.WriteLine ("Отрицание на: " + _check01.ToString () + ": " + _exp03);



		}
	}
}
