using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string [,] table = new string[2, 3];
			//Въвеждане на Първи ред
			table [0, 0] = "Иван";table [0, 1] = "Василев";table [0, 2] = "53";

			//Въвеждане на Втори ред

			table [1, 0] = "Васил";table [1, 1] = "Иванов";table [1, 2] = "35";
			//Печат
			Console.Write("Кой ред искате да видите?:  ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) -1;

			Console.WriteLine ((table[_index, 0])[0]+"."+ table [_index, 1]+ ", "+ table[_index, 2]+ "г.");








			//String[] row = new string[3];
			//row[0] = "Ред 1";
			//row[1] = "Ред 2";
			//row[2] = "Ред 3";

			//Console.WriteLine ("Масив row:" + row[0]+", " + row[1]+", " +row[2]+", " + "\n");
			//String[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
			//Console.WriteLine ("Броят на числата в масива: \n" + "1,2,3,4,5,6,7,8,9\n\ne:" + parse.Length);
			//String List1 = string.Join (";", parse);
			//Console.WriteLine ("Новият стринг е:\n" + List1 + "\n\n");



		}
	}
}
