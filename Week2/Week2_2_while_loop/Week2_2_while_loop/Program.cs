using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string multiLine = new string('-', 35);
            int counter = 0;

            // Motivational message loop
            Console.WriteLine("Motivational messages:");
            while (counter != 10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                counter++;
            }

            Console.WriteLine(multiLine);

            // Resetting counter
            counter = 1;

            // Display numbers between 1 and 20
            Console.WriteLine("1 ile 20 arasındaki sayılar:");
            while (counter <= 20)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine(multiLine);

            // Resetting counter for even numbers
            counter = 1;

            // Display even numbers between 1 and 20
            Console.WriteLine("1 ile 20 arasındaki çift sayılar:");
            while (counter <= 20)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }

            Console.WriteLine(multiLine);

            // Sum numbers between 50 and 150
            counter = 50;
            int sum = 0;
            while (counter <= 150)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {sum}");

            Console.WriteLine(multiLine);

            // Sum odd and even numbers between 1 and 120
            counter = 1;
            int sumOdd = 0, sumEven = 0;
            while (counter <= 120)
            {
                if (counter % 2 == 0)
                {
                    sumEven += counter;
                }
                else
                {
                    sumOdd += counter;
                }
                counter++;
            }
            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {sumEven}");
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {sumOdd}");

            Console.Read();
        }
    }
}
