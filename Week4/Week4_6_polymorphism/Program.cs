using Polymorphism;

namespace Week4_6_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance from a constructor
            BaseGeometricShape square = new Square(21);
            BaseGeometricShape rectangle = new Rectangle(32, 45);
            BaseGeometricShape rightTriangle = new RightTriangle(3, 4);

            // Calculate area and display
            Console.WriteLine("Karenin Alanı: " + square.CalculateArea());
            Console.WriteLine("Dikdörtgenin Alanı: " + rectangle.CalculateArea());
            Console.WriteLine("Dik Üçgenin Alanı: " + rightTriangle.CalculateArea());
        }
    }
}
