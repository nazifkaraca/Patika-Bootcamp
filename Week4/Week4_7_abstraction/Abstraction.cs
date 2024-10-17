
using System.Reflection;

namespace Abstraction
{
	// Create an interface for mandatory properties and methods
	public interface IData
	{
		string Name { get; set; }
		string Surname { get; set; }
		string Occupation { get; set; }
		void Gorev();
	}

	// Personnel class inherits necessities from IData interface
	public abstract class Personnel : IData
	{
		// Create necessary properties here
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Occupation { get; set; }

		// Create a constructor for ease
		public Personnel(string name, string surname, string occupation)
		{
			Name = name;
			Surname = surname;
			Occupation = occupation;
		}

		// Create Gorev method determined by interface
		public abstract void Gorev();
	}

	// Developer inherited Personnel methods and properties
	public class Developer : Personnel
	{
		// Create a Developer constructor which takes reference of Personnel constructor
		public Developer(string name, string surname) : base(name, surname, "Yazılımcı") { }

		// Override base Gorev method for modifications
        public override void Gorev()
        {
            Console.WriteLine($"{Name} {Surname}, {Occupation} olarak çalışıyorum.");
        }
    }

    // Project Manager inherited Personnel methods and properties
    public class ProjectManager : Personnel
	{
        // Create a Project Manager constructor which takes reference of Personnel constructor
        public ProjectManager(string name, string surname) : base(name, surname, "Proje Yöneticisi") { }

		// Override base Gorev method for modifications
        public override void Gorev()
        {
            Console.WriteLine($"{Name} {Surname}, {Occupation} olarak çalışıyorum.");
        }
    }
}
