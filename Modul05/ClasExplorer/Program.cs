using System;

namespace ClasExplorer
{
	public class person
	{
		private string _userName ="";
		private string _userPass ="";

		private  string _userID ="";
		private string _userFName ="";
		private string _userLName ="";

		public string  userName {
			get {
				return _userLName;
			}
		}
			public string  userPass
			{
				get { return _userPass;
				}
		}

		public string userID 
		{
			get{ return _userID; }
			set{ _userID = value; }
		}
		public string userFName 
		{
			get{ return _userFName; }
			set{ _userFName = value; }
		}
		public string userLName
		{
			get{ return _userLName;}
			set{ _userLName = value;}
		}

		public  person (string _user, string _pass)
		{			
			sheckUser (_user, _pass);



	}
		private bool sheckUser(string _user, string _pass)
		{

		if (_user == "user" && _pass == "pass")
			_userName = _user;
		    _userPass = _pass;

				//попълване на пропъртита
				userID = "4455845";
			    userFName = "Мартин";
			userLName = "Димитров";

			return true;

		}

	}

	class MainClass
	{
		
		public static void Main (string[] args)
		{
			Console.Write ("Потребител:"); string _user = Console.ReadLine ();
			Console.Write ("Парола:");     string _pass = Console.ReadLine ();
			//Дефиниране на клас
			person _person = new person (_user, _pass);

			//Достъпвяне на клас
				_person.userFName = "Първо име";
			   Console.WriteLine ( _person.userFName + "" + _person.userLName);
			//Console.WriteLine (_person.getWelcomeMessage());
			//_person.simpleString;//достъпва се, защото е public
			//_person.user; 		//достъпва се, защото е public
			//_person.hideenString // не може да се дистъпи, защото е privet 
		}
	}
}
