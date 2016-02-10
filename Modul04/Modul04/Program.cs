using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = { 
				{ "Иван", "Гeоргиев", "19"  },
				{ "Пешо", "Пешев", "20"  },
				{ "Росен", "Иванов", "30"  },
				{ "Марио", "Гeоргиев", "40"  },
				{ "Джо", "Анев", "50"  },
				{ "Ванчо", "Ванчев", "55"  },
				{ "Тони", "Пешев", "60"  },
			};
			//Антетка на таблица
			Console.WriteLine ("Име".PadRight(10)+ "Фамиля".PadRight(12) + "Години".PadRight(3));
			Console.WriteLine ("============================");
			//Проверка за броя на символите в масива
			//Console.WriteLine (_table.Length);
			//Тяло на таблица
			//пример с FOR

//			for(int i = 0; i < _table.Length/3; i++)
//			{
//				for (int j=0; j<3; j++)
//				{
//					Console.Write (_table[i,j].PadRight(12));
//
//				}
//			
//					Console.WriteLine ();	//код на цикъла
//			

			//Пример с WHILE
//			int i = 0;
//			while (i < _table.Length/3)
//			{Console.WriteLine (
//				_table[i, 0].PadRight(10)+ 
//				_table[i, 1].PadRight(12) + 
//				_table[i, 2].PadRight(3));
			Console.WriteLine ("---------------------------");
//				
			//				i++;}
			//Пример с DO.......WHILE
			int i=0;
			do{
				//Код
				Console.WriteLine (
				_table[i, 0].PadRight(10)+ 
				_table[i, 1].PadRight(12) + 
				_table[i, 2].PadRight(3));
				i++;
			} while( i < _table.Length /3);

			}


		}

}

