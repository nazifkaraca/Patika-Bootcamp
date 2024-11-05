using Week_7_3_patikaflix;
using static Week_7_3_patikaflix.Patikaflix;

namespace Week_7_3_patikaflix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patikaflix> tvshows = new();
            List<string> titles = new() { "Name", "ProductionDate", "Genre", "ReleaseDate", "Director", "Platform" };
            

            bool toContinue = true;

            Console.WriteLine("----------- Patikaflix'e Hoşgeldiniz -----------");

            do
            {

                Console.WriteLine("Oluşturmak istediğiniz dizinin bilgilerini giriniz.");

                // Give titles as input and returns user input assigned to Patikaflix class
                var show = Patikaflix.CreateShow(titles);
                tvshows.Add(show);

                Console.WriteLine("Dizi eklemek istiyor musunuz? (y/n): ");
                toContinue = Console.ReadLine() == "y" ? true : false;

                Console.WriteLine("-------------------------");

            } while (toContinue);

            // İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz.

            List<PatikaflixComedy> comedySeries = PatikaflixComedy.ComedySeries(tvshows);

            // Order comedy movies by name then director
            var ordered = comedySeries.OrderBy(x => x.Name).ThenBy(x => x.Director);

            // Print them on the screen
            Console.WriteLine("Komedi Türünde Olan Diziler:");
            foreach (var show in ordered)
            {
                Console.WriteLine($"Dizi Adı: {show.Name}, Türü: {show.Genre}, Yönetmen: {show.Director}");
            }

        }
    }
}
