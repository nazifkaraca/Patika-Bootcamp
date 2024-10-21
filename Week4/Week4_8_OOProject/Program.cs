using System.Xml.Linq;

namespace Week4_8_OOProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool devam = true;
            string multiLine = new string('-', 35);

            do
            {
                // Get user choice
                Console.Write("(1) Telefon Üret\n(2) Bilgisayar Üret\nSeçim yapınız: ");
                char choice = Console.ReadLine()[0];

                Console.WriteLine(multiLine);

                switch (choice)
                {
                    case '1':
                        // Determine parameters for the object initiliazer
                        BaseMakine phone = new Telefon
                        (
                            Convert.ToInt32(WriteRead("Seri Numarası: ")),
                            WriteRead("Ürünün İsmi: "),
                            WriteRead("Açıklama: "),
                            WriteRead("İşletim Sistemi: "),
                            Convert.ToBoolean(WriteRead("Bluetooth (true/false): "))
                        );

                        // Print multiple lines
                        Console.WriteLine(multiLine);

                        // Show entered information abot the device
                        phone.BilgileriYazdir();

                        break;

                    case '2':
                        // Determine parameters for the object initiliazer
                        BaseMakine computer = new Bilgisayar
                        (
                            Convert.ToInt32(WriteRead("Seri Numarası: ")),
                            WriteRead("Ürünün İsmi: "),
                            WriteRead("Açıklama: "),
                            WriteRead("İşletim Sistemi: "),
                            Convert.ToInt32(WriteRead("USB Giriş Sayısı: ")),
                            Convert.ToBoolean(WriteRead("Bluetooth (true/false): "))
                        );
                        
                        // Print multiple lines
                        Console.WriteLine(multiLine);

                        // Show entered information abot the device
                        computer.BilgileriYazdir();

                        break;
                }

                // Print multiple lines
                Console.WriteLine(multiLine);

                // Ask user whether to continue
                Console.Write("Ürün oluşturmaya devam etmek ister misiniz? (y/n): ");
                devam = Console.ReadLine()[0] == 'y' ? true : false;

                // Clear screen for better UI
                Console.Clear();

            } while (devam);
        }

        // Both write and read operations can be done here
        static string? WriteRead(string text)
        {
            Console.Write(text);
            string answer = Console.ReadLine();

            return answer;
        }
    }
}
