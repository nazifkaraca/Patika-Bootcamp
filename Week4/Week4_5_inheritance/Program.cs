using Inheritance;

namespace Week4_5_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of Teacher using an object initializer
            Teacher teacher = new Teacher
            {
                Name = "Mustafa Kemal",
                Surname = "Atatürk",
                Salary = 1923
            };
            // Display the properties of the created instance
            teacher.Introduce();

            // Create multiple lines in the screen
            Console.WriteLine(new string('-', 35));

            // Create a new instance of Student using an object initializer
            Student student = new Student
            {
                Name = "Sabiha",
                Surname = "Gökçen",
                StudentNumber = 1936
            };
            // Display the properties of the created instance
            student.Introduce();

            Console.ReadKey();
        }
    }
}
