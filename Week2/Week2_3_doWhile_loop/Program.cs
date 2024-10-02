namespace Week2_3_doWhile_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            string multiLine = new string('-', 35);
            int limit;

            // Get and validate input from the user for the while loop
            do
            {
                Console.Write("Bir pozitif tamsayı limit değer giriniz: ");
            } while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 0);

            // While loop
            while (sayac < limit)
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            }

            Console.WriteLine(multiLine);

            int limit2 = 0;
            // Do/while loop
            do
            {
                // Reset sayac
                sayac = 0;

                // Get and validate input from the user for the do/while loop
                do
                {
                    Console.Write("Bir pozitif tamsayı limit değer giriniz (çıkış için 0 yazın): ");
                } while (!int.TryParse(Console.ReadLine(), out limit2));

                while (sayac < limit2)
                {
                    Console.WriteLine("Ben bir Patika'lıyım");
                    sayac++;
                }

            } while (limit2 != 0);
        }
    }
}
