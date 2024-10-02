using System;
using System.Globalization;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kendime inanıyorum:
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım" +
                    "işini hallederim!");
            }
            

            // 1 ile 20 arasındaki sayılar
            for (int j = 1; j <= 20; j++)
            {
                Console.WriteLine(j);
            }


            // 1 ile 20 arasındaki çift sayılar
            for (int k = 2; k < 20; k += 2)
            {
                Console.WriteLine(k);
            }


            // 50 ile 150 arasındaki sayıların toplamı
            int sum = 0;

            for (int l = 50; l <= 150; l++)
            {
                sum += l;
            }

            Console.WriteLine($"50-150 arasındaki sayıların toplamı: {sum}");


            // 1 ile 120 arasındaki tek ve çift sayıların toplamı
            int sum_odd = 0, sum_even = 0;
            for (int m = 1; m <= 120; m++)
            {
                if (m % 2 == 0)
                    sum_even += m;
                else
                    sum_odd += m;
            }

            Console.WriteLine($"Tek sayıların toplamı: {sum_odd}");
            Console.WriteLine($"Çift sayıların toplamı: {sum_even}");


            Console.Read();
        }

           

    }
}