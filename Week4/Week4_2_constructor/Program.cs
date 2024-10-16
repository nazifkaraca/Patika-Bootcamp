using Baby;
using System.Threading;

namespace Week4_2_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance from an no paramater class
            Bebek bebek = new Bebek();
            // Wait a sec to see if datetime works correctly
            Thread.Sleep(1000);
            // Create an instance from a constructor which takes parameters
            Bebek bebekcan = new Bebek("bebek", "bebekcan");

            Console.ReadKey();  
        }
    }
}
