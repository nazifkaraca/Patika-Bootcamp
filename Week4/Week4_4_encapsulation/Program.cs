using Araba;

namespace Week4_4_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car scirocco = new Car("Volswagen", "Scirocco", "Black");
            scirocco.Door = 5;
            scirocco.DisplayCar();

            Console.WriteLine(new string('-', 35))d;

            Car camaro = new Car("Chevrolet", "Camaro", "Black");
            camaro.Door = 4;
            camaro.DisplayCar();

            Console.ReadKey();
        }
    }
}
