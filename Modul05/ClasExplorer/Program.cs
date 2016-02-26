using System;

namespace ClasExplorer
{

	public class person
	{
		public string simpleString = "тестова променлива от клас";
		public string user = "";
		private string hiddenString = ""; 
		public  person (string _ini)
		{
			if (_ini == "password1") hiddenString = "Потребител 1";
			if (_ini == "password2") hiddenString = "Потребител 2";

			user = hiddenString;
				
			if (hiddenString.Length > 0) simpleString = "Добре дошли отново,"+ user +"!" ;
			else simpleString = "Вие нямата достъп до тазо програма";
			//simpleString ="Промяня на променлива при инициализиране";
			
		}

	}
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			Console.Write ("Парола:");
			string _user = Console.ReadLine ();
			//Дефиниране на клас
			person _person = new person (_user);

			//Достъпвяне на клас
			Console.WriteLine (_person.simpleString);
			//_person.simpleString;
			//_person.user;
			//_person.hideenString // не може да се дистъпи, защото е privet 
		}
	}
}
