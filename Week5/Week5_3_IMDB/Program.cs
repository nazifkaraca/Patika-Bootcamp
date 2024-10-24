using System;
using System.Collections.Generic;
using System.Linq;

public class Film
{
    public string Name { get; set; }
    public double ImdbScore { get; set; }

    public Film(string name, double imdbScore)
    {
        Name = name;
        ImdbScore = imdbScore;
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmList = new List<Film>();
        bool isContinue;

        // Film ekleme döngüsü
        do
        {
            // Kullanıcıdan film adı ve IMDb puanı al
            Console.Write("Film adı: ");
            string filmName = Console.ReadLine();

            Console.Write("IMDb puanı: ");
            double imdbScore = Convert.ToDouble(Console.ReadLine());

            // Listeye filmi ekle
            filmList.Add(new Film(filmName, imdbScore));

            // Kullanıcıya devam etmek isteyip istemediğini sor
            Console.Write("\nYeni bir film eklemek ister misiniz? (y/n): ");
            isContinue = Console.ReadLine().ToLower() == "y";

        } while (isContinue);

        // 1. Bütün filmleri listele
        Console.WriteLine("\n--- Tüm Filmler ---");
        foreach (var film in filmList)
        {
            Console.WriteLine($"Film: {film.Name}, IMDb Puanı: {film.ImdbScore}");
        }

        // 2. IMDb puanı 4 ile 9 arasında olan filmleri listele
        Console.WriteLine("\n--- IMDb Puanı 4 ile 9 Arasında Olan Filmler ---");
        var filteredByImdb = filmList.Where(f => f.ImdbScore >= 4 && f.ImdbScore <= 9).ToList();
        foreach (var film in filteredByImdb)
        {
            Console.WriteLine($"Film: {film.Name}, IMDb Puanı: {film.ImdbScore}");
        }

        // 3. İsmi 'A' ile başlayan filmleri listele
        Console.WriteLine("\n--- İsmi 'A' ile Başlayan Filmler ---");
        var filteredByName = filmList.Where(f => f.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
        foreach (var film in filteredByName)
        {
            Console.WriteLine($"Film: {film.Name}, IMDb Puanı: {film.ImdbScore}");
        }

        Console.ReadLine();
    }
}
