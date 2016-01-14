using System;

namespace Uprajnenia
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			//Rotativka
			string[] row = {"портокали","банани","лимони"};
			var r = new Random();
			int[] a = new int[3] {r.Next(0,3), r.Next(0,3), r.Next(0,3)};


			Console.WriteLine(row[a[0]]+" "+row[a[1]]+" "+row[a[2]]);

			int pechalba = 0;

			// Три еднакви
			if ( (a[0] == a[1]) && (a[0] == a[2]) ) pechalba += 5;

			// Две еднакви
			if ( (a[0] == a[1]) || (a[0] == a[2]) || (a[1] == a[2]) ) pechalba += 5;

			Console.WriteLine("Печелите "+pechalba+" точки");



			//Ротативка - втори вариант за същото
			var I = new Random();
			int[] l = new int[4] {I.Next(0,3), I.Next(0,3), I.Next(0,3),0};
			if ( (l[0] == l[1]) && (l[0] == l[2]) ) l[3] = 10;
			else if ( (l[0] == l[1]) || (l[0] == l[2]) || (l[1] == l[2]) ) l[3] = 5;
			string[] row1 = {"портокали","банани","лимони"};
			Console.WriteLine(row1[l[0]]+" "+row1[l[1]]+" "+row1[l[2]]+"\nПечелите "+l[3]+" точки");








		}
	}
}
