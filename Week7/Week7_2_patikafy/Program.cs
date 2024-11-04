using System.Collections.Generic;

namespace Week7_2_patikafy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create multiple lines
            string multiLine = new string('-', 50);

            // Create a list containing Patikafy class
            List<Patikafy> songs = new List<Patikafy>
            {
                new Patikafy("Ajda Pekkan", "Pop", 1968, 20m),
                new Patikafy("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10m),
                new Patikafy("Funda Arar", "Pop", 1999, 3m),
                new Patikafy("Sertab Erener", "Pop", 1994, 5m),
                new Patikafy("Sıla", "Pop", 2009, 3m),
                new Patikafy("Serdar Ortaç", "Pop", 1994, 10m),
                new Patikafy("Tarkan", "Pop", 1992, 40m),
                new Patikafy("Hande Yener", "Pop", 1999, 7m),
                new Patikafy("Hadise", "Pop", 2005, 5m),
                new Patikafy("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10m),
                new Patikafy("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2m)
            };

            #region Q1
            // Q1 - Adı 'S' ile başlayan sanatçılar
            Console.WriteLine("Q1 - Adı 'S' ile başlayan sanatçılar:\n");

            var artistNames = songs.Where(name => name.Name.StartsWith('S')).Select(name => name.Name);

            foreach (var s in artistNames) Console.WriteLine(s); 
            #endregion

            Console.WriteLine(multiLine);

            #region Q2
            // Q2 - Albüm satışları 10 milyon'un üzerinde olan sanatçılar
            Console.WriteLine("Q2 - Albüm satışları 10 milyon'un üzerinde olan sanatçılar:\n");

            var sales = songs.Where(sales => sales.Sales > 10m);

            foreach (var s in sales) Console.WriteLine(s); 
            #endregion

            Console.WriteLine(multiLine);

            #region Q3
            // Q3 - 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
            Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:\n");

            var oldButGold = songs.Where(old => old.ReleaseDate < 2000 && old.Genre == "Pop");

            foreach (var old in oldButGold) Console.WriteLine(old); 
            #endregion

            Console.WriteLine(multiLine);

            // Q4 - En çok albüm satan şarkıcı
            #region Q4
            Console.WriteLine("Q4 - En çok albüm satan şarkıcı:\n");

            var mostSeller = songs.OrderByDescending(s => s.Sales).FirstOrDefault();

            Console.WriteLine(mostSeller);
            #endregion

            Console.WriteLine(multiLine);

            #region Q5
            // Q5 - En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
            Console.WriteLine("Q5 - En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı:\n");

            // Find min and max values on release date
            var newestDate = songs.Max(s => s.ReleaseDate);
            var oldestDate = songs.Min(s => s.ReleaseDate);

            // Assign row values to newest and oldest when release date matches
            var newest = songs.FirstOrDefault(s => s.ReleaseDate == newestDate);
            var oldest = songs.FirstOrDefault(s => s.ReleaseDate == oldestDate);

            // Print name and year information
            Console.WriteLine($"En yeni çıkış yapan {newest?.Name} isimli sanatçının çıkış yaptığı yıl {newest?.ReleaseDate}.");
            Console.WriteLine($"En eski çıkış yapan {oldest?.Name} isimli sanatçının çıkış yaptığı yıl {oldest?.ReleaseDate}.");
            #endregion

            Console.WriteLine(multiLine);
        }
    }
}
