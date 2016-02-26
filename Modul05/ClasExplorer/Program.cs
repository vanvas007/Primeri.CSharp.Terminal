using System;

namespace ClasExplorer
{

	public class person
	{
		private string simpleString = "тестова променлива от клас";
		private string user = "";
		private string hiddenString = ""; 
		public  person (string _ini)
		{			
			getUser (_ini);
			setWelcomeText ();

			//simpleString ="Промяня на променлива при инициализиране";
			
		}


		private void getUser(string _ini)
		{
			if (_ini == "password1") hiddenString = "Потребител 1";
			if (_ini == "password2") hiddenString = "Потребител 2";
			user = hiddenString;
		}
		private void setWelcomeText ()
		{
			if (hiddenString.Length > 0) simpleString = "Добре дошли отново,"+ user +"!" ;
			else simpleString = "Вие нямата достъп до тазо програма";
		}
		public string getWelcomeMessage()
		{
			return simpleString;
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
			Console.WriteLine (_person.getWelcomeMessage());
			//_person.simpleString;//достъпва се, защото е public
			//_person.user; 		//достъпва се, защото е public
			//_person.hideenString // не може да се дистъпи, защото е privet 
		}
	}
}
