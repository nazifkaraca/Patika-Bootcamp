using System.Globalization;

namespace Week2_4_TatilUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char proceed = 'y'; // Declare proceed outside the loop to avoid scope issues

            do
            {
                string requestedLocation = string.Empty;
                int guests = 0;
                int transport = 0;
                string multiLine = new string('-', 35);
                string[] locations = { "bodrum", "çeşme", "marmaris" };
                int price = 0; // This variable is currently unused but can be used later for calculations

                // Greet the user
                Console.WriteLine("Yol Arkadaşım: Tatil Uygulamasına Hoşgeldin!\n");

                // Print multi line for better UI
                Console.WriteLine(multiLine);

                // 1 - Which Location?
                do
                {
                    // Ask for location
                    Console.WriteLine("1 - Bodrum(Paket başlangıç fiyatı 4000 TL)");
                    Console.WriteLine("2 - Marmaris(Paket başlangıç fiyatı 3000 TL)");
                    Console.WriteLine("3 - Çeşme(Paket başlangıç fiyatı 5000 TL)\n");

                    Console.Write("Gitmek istediğiniz lokasyonun ismini giriniz: ");

                    // Check for null-references with question mark
                    requestedLocation = Console.ReadLine()?.ToLower();

                    // If input is not in the locations list, then throw an error
                    if (!locations.Contains(requestedLocation))
                    {
                        Console.WriteLine(multiLine);

                        Console.WriteLine("Lütfen geçerli bir lokasyon giriniz.");
                        Console.WriteLine("Bodrum, Marmaris veya Çeşme şehirleri kapsanmaktadır.");

                        Console.WriteLine(multiLine);
                    }

                    // Continue until location is correct
                } while (!locations.Contains(requestedLocation));

                Console.WriteLine(multiLine);


                // 2 - How Many Guests?
                do
                {
                    Console.Write("Kaç kişi için planlama yapacaksınız?: ");
                    // Return bool based on input either valid or invalid 
                    bool boolGuests = int.TryParse(Console.ReadLine(), out guests);

                    // Check if conversion successful or number equal and lower than zero
                    if (!boolGuests || guests <= 0)
                    {
                        Console.WriteLine(multiLine);

                        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");

                        Console.WriteLine(multiLine);
                    }

                    // Continue until a valid number entered
                } while (guests <= 0);

                Console.WriteLine(multiLine);

                // 3 - Information About Location
                switch (requestedLocation)
                {
                    case "bodrum":
                        Console.WriteLine("Bodrum yapılabilecekler listesi:\n");
                        Console.WriteLine("- Bodrum Kalesi ve Sualtı Arkeoloji Müzesi'ni gezme");
                        Console.WriteLine("- Gümüşlük’te gün batımını izleme");
                        Console.WriteLine("- Barlar sokağında gece hayatı");
                        break;

                    case "çeşme":
                        Console.WriteLine("Çeşme yapılabilecekler listesi:\n");
                        Console.WriteLine("- Plajlarda yüzme ve güneşlenme");
                        Console.WriteLine("- Alaçatı’da rüzgar sörfü");
                        Console.WriteLine("- Ilıca Plajı'nda termal sulardan faydalanma");
                        break;

                    case "marmaris":
                        Console.WriteLine("Marmaris yapılabilecekler listesi:\n");
                        Console.WriteLine("- Tekne turları ve koyları keşfetme");
                        Console.WriteLine("- Marmaris Kalesi ve müzesini ziyaret etme");
                        Console.WriteLine("- Su sporları ve dalış");
                        break;
                }


                Console.WriteLine(multiLine);

                // 4 - Which Transportation Way?
                do
                {
                    Console.WriteLine("(1) Kara Yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
                    Console.WriteLine("(2) Hava Yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\n");
                    Console.Write("Hangi ulaşım yolunu tercih edersiniz?: ");
                    bool boolTransport = int.TryParse(Console.ReadLine(), out transport);

                    if (!boolTransport || transport <= 0 || transport > 2)
                    {
                        Console.WriteLine(multiLine);

                        Console.WriteLine("Lütfen geçerli bir sayı girin");

                        Console.WriteLine(multiLine);
                    }

                } while (transport <= 0 || transport > 2);

                Console.WriteLine(multiLine);

                // 5 - Print Preferences of the User
                string transportString = transport == 1 ? "Kara Yolu" : "Hava Yolu"; // if 1: Kara Yolu, if 2: Hava Yolu

                Console.WriteLine($"Lokasyon: {requestedLocation.ToUpper()}");
                Console.WriteLine($"Kişi Sayısı: {guests} Kişi");
                Console.WriteLine($"Lokasyon: {transportString}");

                Console.WriteLine(multiLine);

                // 6 - Calculate Overall 
                // Calculate location price
                int locationPrice = 0;

                if (requestedLocation == locations[0]) // Price for Bodrum
                    locationPrice = 4000;
                else if (requestedLocation == locations[1]) // Price for Çeşme
                    locationPrice = 5000;
                else // Price for Marmaris
                    locationPrice = 3000;

                // Calculate transportation price
                int transportPrice = transport == 1 ? 1500 : 4000; // if Kara Yolu: 1500 TL, if Hava Yolu: 4000 TL

                // Print overall price
                price = (locationPrice + transportPrice) * guests;
                Console.WriteLine($"Ödeyeceğiniz toplam fiyat: {price}");

                Console.WriteLine(multiLine);

                // 7 - Ask Whether to Continue
                Console.Write("Yeni bir plan istiyor musunuz? (y/n): ");
                proceed = Console.ReadLine()?.ToLower()[0] ?? 'n'; // Null-safe reading and defaulting to 'n'

                // Clear console
                Console.Clear();

            } while (proceed != 'n'); // Continue the loop as long as proceed is not 'n'
        }
    }
}
