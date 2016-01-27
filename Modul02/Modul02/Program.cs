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
			string program_name  = " Модул 02-примери";
			string program_version = "1.0";
			//За програмата

			Console.WriteLine (program_name);
			Console.WriteLine ("Версия: " + program_version + "n\n");



//			събиране на числа
			a=10;
			b=5;

			sum = a + b;

//			писане в конзолата
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);




			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на + = ");
			a += b; //a=10 + 5, a= a + b
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на - = ");
			a -= b; //a=10 + 5, a= a + b
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на * = ");
			a *= b; //a=10 + 5, a= a + b
			Console.WriteLine (a);


			Console.WriteLine ("\nИзползване на ++ ");
			a ++ ; //a=10 + 5, a= a + b
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на -- ");
			a -- ; //a=10 + 5, a= a + b
			Console.WriteLine (a);

			Console.WriteLine ("Стандартно делене:" + (14 / 4).ToString());
			Console.WriteLine ("Остатък от делене:" + (14 % 4).ToString());
			Console.WriteLine (a);







		}
	}
}
