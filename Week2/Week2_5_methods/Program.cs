namespace Week2_5_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 - Geriye Değer Döndürmeyen Bir void metot.
            SagopaKajmer();

            // 2 - Geriye Tamsayı Döndüren Bir Metot
            Console.WriteLine("Reminder number: " + RandomInt() + "\n");

            // 3 - Parametre Alan ve Geriye Değer Döndüren Bir Metot
            Console.WriteLine("Multiplication: " + Multiplication(5, 3) + "\n");

            // 4 - Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
            Greetings("Nazif", "Karaca");

            Console.Read();
        }

        /// <summary>
        /// Generates my a verse from a song.
        /// </summary>
        /// <returns>Lyrics from Sagopa Kajmer - Kürdan Kollar</returns>
        static void SagopaKajmer()
        {
            Console.WriteLine("1 - Geriye Değer Döndürmeyen Bir void metot.");

            Console.WriteLine("Bilgilerimiz sis, kaybolur batan güneş gibi.\r\n" +
                "Akıl inzivaya çekilir,\r\n" +
                "Bir gün terk edip gider bizi.\n");
        }

        /// <summary>
        /// Randomly generates a number between 0 and 100.
        /// </summary>
        /// <returns>Remainder of dividing the number by 2.</returns>
        static double RandomInt()
        {
            // Generate random number between 0 and 100.
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            Console.WriteLine("2 - Geriye Tamsayı Döndüren Bir Metot.");

            return (double)randomNumber / 2;
        }

        /// <summary>
        /// Returns the multiplication of two numbers taken as parameters.
        /// </summary>
        /// <returns>Multiplication of two parameters.</returns>
        static double Multiplication(double x, double y)
        {
            Console.WriteLine("3 - Parametre Alan ve Geriye Değer Döndüren Bir Metot.");
            
            return x * y;
        }
        
        /// <summary>
        /// Personalized greetings.
        /// </summary>
        /// <param name="name">Your name.</param>
        /// <param name="surname">Your surname.</param>
        /// <returns>Multiplication of two parameters.</returns>
        static void Greetings(string name, string surname)
        {
            Console.WriteLine("4 - Parametre Alan ve Geriye Değer Döndürmeyen bir Metot.");

            Console.WriteLine($"Hoş Geldiniz {name} {surname}.");
        }
    }
}
