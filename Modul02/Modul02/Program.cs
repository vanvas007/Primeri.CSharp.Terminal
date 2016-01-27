using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
//			ДЕФИНИРАНЕ НА ПРОМЕНЛИВИ
			int a =0, b=0;
			int sum = 0;
//			събиране на числа
			a=5;
			b=10;

			sum = a + b;

//			писане в конзолата
			Console.Write (a);
			Console.Write ("+");
			Console.Write (b);
			Console.Write ("=");
			Console.WriteLine (sum);
		}
	}
}
