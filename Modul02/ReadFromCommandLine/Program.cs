using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//дефиниране на променливи
			int a = 5, b = 0;
			//въвеждане на входни параметри
			Console.Write ("Моля въведете а: ");
			b = Convert.ToInt32 (Console.ReadLine ());
			//печат на резултат
			Console.WriteLine ( "Резултата а+б е:" + (a+b).ToString()+ "\n\n\n" );

			string test = "1";
			test += ",2";
			test += ",100";
			test += ",4";
			test += ",5";
			test += ",6";
			Console.WriteLine ("Събиране += : " + test + "\n\n");

			test = test.Replace ("," , ";");
			Console.WriteLine ("Работа с Replace : " + test + "\n\n");

			Console.WriteLine ("Трети знак: " + test.Split (';')[2] + "\n\n");
		}
	}
}
