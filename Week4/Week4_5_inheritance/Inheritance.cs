using System.Globalization;
using System.Threading.Channels;

namespace Inheritance
{
	// Create base class inheriting a method and properties to child classes
	public abstract class BasePerson
	{
		public required string Name { get; set; }
		public required string Surname { get; set; }

		// Virtual class to be overridden by child classes
		public virtual void Introduce()
		{
            Console.WriteLine($"Merhaba {Name} {Surname}!");
		}
	}

	// Sealed class to prevent inheritation
	public sealed class Teacher : BasePerson
    {
		public int Salary { get; set; }

		// Override the base class method
        public override void Introduce()
        {
            base.Introduce();
			Console.WriteLine($"Your salary is {Salary}.");
        }
    }

    // Sealed class to prevent inheritation
    public sealed class Student : BasePerson 
	{ 
		public int StudentNumber { get; set; }

		// Override the base class method
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"Your student number is {StudentNumber}.");
        }
    }
}
