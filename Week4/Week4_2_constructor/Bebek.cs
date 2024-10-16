namespace Baby
{
	public class Bebek
	{
		// Creating the field and get/set operations
		private string _name { get; set; }
		private string _surname { get; set; }
		private DateTime _birth { get; set; }

		// Create an empty class which takes no parameters
		public Bebek() 
		{
			_birth = DateTime.Now;

			Console.WriteLine($"Ingaa\nİsim: İsimsiz\nSoyisim: Soyisimsiz\nDoğum Tarihi: {_birth}");
		}

		// Create a class which takes name and surname as parameters
		public Bebek(string name,  string surname)
		{
			_name = name;
			_surname = surname;
			_birth = DateTime.Now;

            Console.WriteLine($"Ingaa\nİsim: {name}\nSoyisim {surname}\nDoğum Tarihi: {_birth}");
		}
	}

}
