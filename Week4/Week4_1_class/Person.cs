namespace PersonNamespace
{
	public class Person
	{
		public string Name { get; set; }
        	public string Surname { get; set; }
		public string Occupation { get; set; }
        	public DateTime BirthDate { get; set; }

		public void DisplayPerson()
		{
            		Console.WriteLine($"{Name} {Surname} isimli kişi bir {Occupation}'dir. {BirthDate} tarihinde doğmuştur.");
		}
	}
}
