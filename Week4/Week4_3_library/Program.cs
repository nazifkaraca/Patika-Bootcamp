using LibraryApp;
using System.Threading;

namespace Week4_3_library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance from a default constructor
            Library newRegistration = new Library();

            newRegistration.AuthorName = "Ayşe";
            newRegistration.AuthorSurname = "Kulin";
            newRegistration.BookName = "Aylin";
            newRegistration.PageCount = 398;
            newRegistration.PublishHouse = "Remzi Kitapevi";

            // Show new registration information
            newRegistration.LibraryDatabase();

            // Create multiple lines
            Console.WriteLine(new string('-', 25));
            // Sleep a sec to see if registration date works
            Thread.Sleep(1000);

            // Create a new registration from a constructor taking parameter
            Library newRegistration2 = new Library("Amat", "İhsan Oktay", 295, "Can Kitapevi");

            Console.ReadLine();

        }
        // Class: A blueprint or template for creating objects.

        // Property: A property is a member that provides a flexible mechanism to read, write, or compute the value of a data field. Properties appear as public data members, but they're implemented as special methods called accessors.

        // New: It is called when you need to create a new instance from a class.

        // Constructor: A constructor is a special class method that is called every time an instance of the class is made.
    }
}
