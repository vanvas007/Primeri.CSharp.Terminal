using System;

namespace ClasExplorer
{

	public class person
	{
		public string simpleString = "тестова променлива от клас";

		public  person ()
		{
			simpleString ="Промяня на променлива при инициализиране";
			
		}

	}
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			//Дефиниране на клас
			person _person = new person ();

			//Достъпвяне на клас
			Console.WriteLine (_person.simpleString);
		}
	}
}
