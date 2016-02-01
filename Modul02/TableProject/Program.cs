using System;

namespace TableProject
{
	class MainClass
	{ //Дефиниране на ENUM
		enum ti {ime=0, familia, godini};
		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string [,] table = new string[2, 3];
			//Въвеждане на Първи ред
			table [0,(int) ti.ime] = "Иван";table [0, (int)ti.familia] = "Василев";table [0, (int) ti.godini] = "53";

			//Въвеждане на Втори ред

			table [1, (int)ti.ime] = "Васил";table [1, (int) ti.familia] = "Иванов";table [1,(int) ti.godini] = "35";


			//Печат
			Console.Write("Кой ред искате да видите?:  ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) -1;

			Console.WriteLine ((
				table[_index, (int)ti.ime])[0]+"."+ 
				table[_index,(int) ti.familia]+ ", "+ 
				table[_index,(int) ti.godini]+ "г.");
			Console.ReadKey();

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
